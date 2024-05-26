using Raylib_cs;
using System.Drawing;
using System.Numerics;

public class Program
{
    // If you need variables in the Program class (outside functions), you must mark them as static
    static string title = "Game Title"; // Window title
    static int screenWidth = 800; // Screen width
    static int screenHeight = 600; // Screen height
    static int targetFps = 60; // Target frames-per-second
    static bool upArrowPressed = false;

    static void Main()
    {
        // Create a window to draw to. The arguments define width and height
        Raylib.InitWindow(screenWidth, screenHeight, title);
        // Set the target frames-per-second (FPS)
        Raylib.SetTargetFPS(targetFps);
        // Setup your game. This is a function YOU define.
        Setup();
        // Loop so long as window should not close
        while (!Raylib.WindowShouldClose())
        {
            // Enable drawing to the canvas (window)
            Raylib.BeginDrawing();
            // Clear the canvas with one color
            Raylib.ClearBackground(Raylib_cs.Color.RayWhite);
            // Your game code here. This is a function YOU define.

            // Adding instructions
            Raylib.DrawText("Press up arrow key or down arrow key", 12, 12, 20, Raylib_cs.Color.Black);

            // Draw the robot
            DrawRobot();

            // Draw multiple circles
            DrawButtons();

            Update();

            //Draw shirt

            if (upArrowPressed)
                Raylib.DrawRectangle(200, 300, 300, 200, Raylib_cs.Color.Red);

            // Stop drawing to the canvas, begin displaying the frame
            Raylib.EndDrawing();
        }
        // Close the window
        Raylib.CloseWindow();
    }

    static void Setup()
    {
        // Your one-time setup code here
    }

    static void Update()
    {
        // Your game code run each frame here
        if (Raylib.IsKeyPressed(KeyboardKey.Up))
        {
            upArrowPressed = true;
        }
    }

    static void DrawRobot()
    {
        // Robot
        Raylib.DrawRectangle(200, 200, 300, 300, Raylib_cs.Color.Blue);
        Raylib.DrawRectangle(280, 70, 140, 140, Raylib_cs.Color.Blue);
        Raylib.DrawRectangle(200, 400, 80, 170, Raylib_cs.Color.Blue);
        Raylib.DrawRectangle(420, 400, 80, 170, Raylib_cs.Color.Blue);
        Raylib.DrawRectangle(400, 200, 210, 80, Raylib_cs.Color.Blue);
        Raylib.DrawRectangle(90, 200, 210, 80, Raylib_cs.Color.Blue);
    }

    static void DrawButtons()
    {
        // Draw buttons
        for (int i = 0; i < 2; i++)
        {
            int x = 300 + i * 100; // Adjust the x position
            int y = 250;         // Fixed y position
            Raylib.DrawCircle(x, y, 20, Raylib_cs.Color.Gold);
        }
    }
}

