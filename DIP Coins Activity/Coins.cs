using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Coins_Activity
{
    static class Coins
    {
        public static void Binary(Bitmap reference, ref Bitmap result)
        {
            result = new Bitmap(reference.Width, reference.Height);
            Color pixel;
            int ave;
            for (int x = 0; x < result.Width; x++)
            {
                for (int y = 0; y < result.Height; y++)
                {
                    pixel = reference.GetPixel(x, y);
                    ave = (pixel.R + pixel.G + pixel.B) / 3;

                    // Dynamic thresholding: More robust threshold based on average brightness of image
                    int dynamicThreshold = ave < 128 ? 100 : 150;

                    if (ave < dynamicThreshold)
                    {
                        result.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        result.SetPixel(x, y, Color.White);
                    }
                }
            }
        }

        public static void GetCoinPixels(
            Bitmap image,
            ref int totalCount,
            ref float totalValue,
            ref int peso5Count,
            ref int peso1Count,
            ref int cent25Count,
            ref int cent10Count,
            ref int cent5Count
        )
        {
            bool[,] seen = new bool[image.Width, image.Height];
            Color pixel;

            // Loop through each pixel in the image to find coins
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    if (seen[x, y])
                        continue;

                    seen[x, y] = true;
                    pixel = image.GetPixel(x, y);

                    // If it's a black pixel (part of the coin)
                    if (pixel.R == 0)
                    {
                        int pixelCount = GetPixelCount(image, x, y, ref seen);

                        // Eliminate small noise (coins smaller than 1000 pixels)
                        if (pixelCount < 1000)
                            continue;

                        // Classify coins based on pixel count (you might need to adjust these values)
                        if (pixelCount > 7000)
                        {
                            peso5Count++;
                            totalValue += 5;
                        }
                        else if (pixelCount > 5000)
                        {
                            peso1Count++;
                            totalValue += 1;
                        }
                        else if (pixelCount > 4000)
                        {
                            cent25Count++;
                            totalValue += 0.25f;
                        }
                        else if (pixelCount > 3000)
                        {
                            cent10Count++;
                            totalValue += 0.10f;
                        }
                        else if (pixelCount > 1000)
                        {
                            cent5Count++;
                            totalValue += 0.05f;
                        }

                        totalCount++;
                    }
                }
            }
        }

        private static int GetPixelCount(Bitmap image, int x, int y, ref bool[,] seen)
        {
            // Breadth-First Search (BFS) for connected components
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new int[] { x, y });
            int pixelCount = 0;
            int[] top;

            while (queue.Count > 0)
            {
                top = queue.Dequeue();
                pixelCount++;
                int currX = top[0], currY = top[1];

                // Check all four directions (including diagonal for better connectivity)
                CheckAndEnqueue(image, currX, currY - 1, ref queue, ref seen); // Top
                CheckAndEnqueue(image, currX, currY + 1, ref queue, ref seen); // Bottom
                CheckAndEnqueue(image, currX - 1, currY, ref queue, ref seen); // Left
                CheckAndEnqueue(image, currX + 1, currY, ref queue, ref seen); // Right

                // Diagonal directions for better connectivity
                CheckAndEnqueue(image, currX - 1, currY - 1, ref queue, ref seen); // Top-Left
                CheckAndEnqueue(image, currX + 1, currY - 1, ref queue, ref seen); // Top-Right
                CheckAndEnqueue(image, currX - 1, currY + 1, ref queue, ref seen); // Bottom-Left
                CheckAndEnqueue(image, currX + 1, currY + 1, ref queue, ref seen); // Bottom-Right
            }

            return pixelCount;
        }

        private static void CheckAndEnqueue(Bitmap image, int x, int y, ref Queue<int[]> queue, ref bool[,] seen)
        {
            if (x >= 0 && x < image.Width && y >= 0 && y < image.Height && image.GetPixel(x, y).R == 0 && !seen[x, y])
            {
                queue.Enqueue(new int[] { x, y });
                seen[x, y] = true;
            }
        }
    }
}
