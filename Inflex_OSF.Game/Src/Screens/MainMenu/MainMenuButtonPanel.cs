using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osuTK;
using osuTK.Graphics;

namespace Infex_OSF.Game.Screens.MainMenu;

public class MainMenuButtonPanel : Container
{
    private readonly MainMenuButton[] buttons;
    private readonly Vector2 buttonSize = new(200, 100);

    public MainMenuButtonPanel(Action onPlay, Action onMultiplayer, Action onSettings, Action onEditor, Action onQuit)
    {
        this.Child = new FillFlowContainer
        {
            Origin = Anchor.Centre,
            Spacing = new Vector2(0, 10),
            Direction = FillDirection.Vertical,
            AutoSizeAxes = Axes.Both,
            Children = this.buttons = new MainMenuButton[]
            {
                new("Play", new Color4(120, 120, 120, 255), this.buttonSize, onPlay),
                new("Multiplayer", new Color4(120, 120, 120, 255), this.buttonSize, onMultiplayer),
                new("Settings", new Color4(120, 120, 120, 255), this.buttonSize, onSettings),
                new("Editor", new Color4(120, 120, 120, 255), this.buttonSize, onEditor),
                new("Quit", new Color4(120, 120, 120, 255), this.buttonSize, onQuit),
            },
        };
    }

    public static int StartingFlow { get; set; }

    public void FlowToPosition(bool movingIn)
    {
        int timing = 50;
        int beginning = StartingFlow;
        int ending = StartingFlow;

        this.buttons[StartingFlow].MoveIntoPlace(new Vector2(-400, 0), timing, movingIn);
        timing += 50;

        for (int i = 1; i < this.buttons.Length; i++)
        {
            if (beginning > 0)
            {
                this.buttons[--beginning].MoveIntoPlace(new Vector2(-400, 0), timing, movingIn);
            }

            if (ending < this.buttons.Length - 1)
            {
                this.buttons[++ending].MoveIntoPlace(new Vector2(-400, 0), timing, movingIn);
            }

            timing += 50;
        }
    }
}