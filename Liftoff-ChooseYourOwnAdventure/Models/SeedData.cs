using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liftoff_ChooseYourOwnAdventure.Data;

namespace Liftoff_ChooseYourOwnAdventure.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<GameDbContext>();
            context.Database.EnsureCreated();
            if (!context.Games.Any())
            {
                context.Games.Add(new Game { Title = "Explore the Spooky Forest", Description = "A short exploration game. What will you see? Who will you meet? What will you become?" });
            }

            if (!context.Storyboards.Any())
            {
                context.Storyboards.Add(new Storyboard { StoryboardID = 1, Option1 = "Say hello", NextStoryboardID1 = 2 , Option2 = "Attack", NextStoryboardID2 = 3});
                context.Storyboards.Add(new Storyboard { StoryboardID = 2, Option1 = "Yes", NextStoryboardID1 = 4, Option2 = "No", NextStoryboardID2 = 5});
                context.Storyboards.Add(new Storyboard { StoryboardID = 3, Option1 = "Back away slowly", NextStoryboardID1 = 7, Option2 = "Attack", NextStoryboardID2 = 8});
                context.Storyboards.Add(new Storyboard { StoryboardID = 4, NextStoryboardID1 = 6 });
                context.Storyboards.Add(new Storyboard { StoryboardID = 5, Option1 = "Give food", NextStoryboardID1 = 9, Option2 = "Back away slowly", NextStoryboardID2 = 7 });
                context.Storyboards.Add(new Storyboard { StoryboardID = 6 });
                context.Storyboards.Add(new Storyboard { StoryboardID = 7, NextStoryboardID1 = 6 });
                context.Storyboards.Add(new Storyboard { StoryboardID = 8, Option1 = "Yes", NextStoryboardID1 = 10, Option2 = "No", NextStoryboardID2 = 11 });
                context.Storyboards.Add(new Storyboard { StoryboardID = 9, Option1 = "Yes", NextStoryboardID1 = 12, Option2 = "No", NextStoryboardID2 = 6 });
                context.Storyboards.Add(new Storyboard { StoryboardID = 10 });
                context.Storyboards.Add(new Storyboard { StoryboardID = 11 });
                context.Storyboards.Add(new Storyboard { StoryboardID = 12 });
            }
        }
    }
}
