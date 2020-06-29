using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liftoff_ChooseYourOwnAdventure.Data;
using Microsoft.EntityFrameworkCore;

namespace Liftoff_ChooseYourOwnAdventure.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            //using (var context = new ApplicationDbContext(
            //                serviceProvider.GetRequiredService<
            //                    DbContextOptions<ApplicationDbContext>>()))
            //{
 
            //    if (context.Games.Any())
            //    {
            //        return;
            //    }
            //    context.Games.Add(new Game { Title = "Explore the Spooky Forest", Description = "A short exploration game. What will you see? Who will you meet? What will you become?", FirstStoryBoardID = 1 });
            //    context.SaveChanges();
            //}

            using (var context = new ApplicationDbContext(
                            serviceProvider.GetRequiredService<
                                DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Storyboards.Any())
                {
                    return;
                }
                context.Storyboards.Add(new Storyboard { Story= "The forest is dark, letting just enough moonlight in for you to see the trail ahead of you. The trees are enormous, stretching far above your head, and they rustle softly in the wind. You have been walking for some time now, listening to the sounds of the forest, when you come across a little man with a little pack on his back and a silver knife strapped to his leg. <br/>You:", Option1 = "Say hello", NextStoryboardID1 = 2, Option2 = "Attack", NextStoryboardID2 = 3 });
                context.Storyboards.Add(new Storyboard { Story = "You greet the little man and he smiles at you. He seems friendly and you end up chatting with him for a bit. He tells you he's headed to pick some fruit from a grove of violet trees to make a pie for his grandmother. <br /> \"It's the best fruit around, but it's hard to get to since it's so deep in the forest. To tell the truth, I'm surprised to find someone else all the way out here. Are you lost?\"", Option1 = "Yes", NextStoryboardID1 = 4, Option2 = "No", NextStoryboardID2 = 5 });
                context.Storyboards.Add(new Storyboard { Story= "You attack! The man stands about as tall as your waist, so it's a simple matter to rush over and knee him in the face. The impact is tremendous - he tumbles away from you, and lies very still after that. You are slightly surprised by this, but he really was a very little man after all, with delicate bones. There's nothing of interest in his pack, but his knife is very high quality, and a pretty silver color too. You take it and leave the body behind. <br /> As you head deeper into the forest you notice that the ambient sounds around you have gone quiet. As you look around to see what must have spooked the animals you spot a wolf standing beneath a nearby tree. Though its body is mostly hidden in shadow, you can see that it is very large, and it is looking at you. <br /> You: ", Option1 = "Back away slowly", NextStoryboardID1 = 7, Option2 = "Attack", NextStoryboardID2 = 8 });
                context.Storyboards.Add(new Storyboard { Story = "He kindly gives you directions to the nearest road and you part on good terms.Eventually you make it back to the trail - you still have no idea where you are, but you can be sure you’re headed somewhere now at least!", NextStoryboardID1 = 6 });
                context.Storyboards.Add(new Storyboard { Story = "\"I know where I’m going, but thank you,\" you say. The little man gives you a respectful nod and you part on good terms. <br /> After a long stretch of walking you see a dark shape under the trees ahead and realize it’s a wolf. Though seated, it’s very large, and it’s looking at you. <br /> You: ", Option1 = "Feed it", NextStoryboardID1 = 9, Option2 = "Back away slowly", NextStoryboardID2 = 7 });
                context.Storyboards.Add(new Storyboard { Story= "You keep walking. You haven’t found what you are looking for yet, and that’s ok. The forest is here for you. You get the feeling you could explore it forever if you wanted to." });
                context.Storyboards.Add(new Storyboard { Story = "You back away slowly from the wolf, projecting as much confidence as someone who’s trying not to trip over anything or walk into a tree can project. Obviously you meant to go this way the entire time. The wolf seems vaguely amused by the whole affair, but at least it lets you leave. Eventually you get far enough away to stop, regain your bearings, and then continue your journey.", NextStoryboardID1 = 6 });
                context.Storyboards.Add(new Storyboard { Story = "You charge forward with a yell. The wolf is a fearsome opponent, but you fight like a thing possessed. You still have the silver knife in your hand and you stab and stab and stab until the wolf is no longer a wolf, just meat. <br /> Are you hungry?", Option1 = "Yes", NextStoryboardID1 = 10, Option2 = "No", NextStoryboardID2 = 11 });
                context.Storyboards.Add(new Storyboard { Story= "You approach the wolf carefully. It doesn’t seem hostile, but still, it is very large. Even seated it’s almost as tall as you are. As you pass by, you notice that it seems very focused on you - or rather, your pack. It snuffs hopefully, and you sigh, then reach into your bag and pull out a strip of jerky. The wolfs tail immediately starts wagging as you toss it the treat, and you are able to slip away while it eats. <br /> By this point the sky is growing dark, and you begin to look for a place to shelter for the night. Though you’re in the middle of the woods at this point, you see a cozy looking log cabin in a small clearing nearby. Do you stop and rest?", Option1 = "Yes", NextStoryboardID1 = 12, Option2 = "No", NextStoryboardID2 = 6 });
                context.Storyboards.Add(new Storyboard { Story = "You feast. <br />There’s a monster in these woods. How long has it been you?", Special="badEnd" });
                context.Storyboards.Add(new Storyboard { Story = "You drop the knife as you realize what you’ve done. You need to get out of here. <br /> Branches scratch your face and tug at your clothes as you run, but you don’t stop. You’re not sure why, but it is very important that you keep moving right now. You come upon a small stream that burbles gently as it winds its way through the woods and clear it in a single leap. As you cross the running water, you feel a sudden sense of relief. Your hands are stained red with blood, but they are still your hands. Maybe you can do better next time." });
                context.Storyboards.Add(new Storyboard { Story = "You smile as you see the cabin. After a long journey, you’re finally home. The space inside is as warm and cozy as you remembered, and as you settle in with a hot drink and some food you catch a glimpse of the wolf through the window. It will stand vigil outside as you sleep." });

                context.SaveChanges();
            }
        }
    }
}
