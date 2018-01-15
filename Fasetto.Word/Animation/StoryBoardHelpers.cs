using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Fasetto.Word.Animation
{
    /// <summary>
    /// Animation helpers for <see cref="StoryBoard"/>
    /// </summary>
    public static class StoryBoardHelpers
    {
        /// <summary>
        /// Adds a slide from right animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take </param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        public static void AddSlideFromRight(this Storyboard p_storyboard, float p_seconds, double p_offset, float p_decelerationRatio = 0.9f)
        {
            // Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(p_seconds)),
                From = new Thickness(p_offset, 0, -p_offset, 0),
                To = new Thickness(0),
                DecelerationRatio = p_decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            p_storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a slide to left animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take </param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        public static void AddSlideToLeft(this Storyboard p_storyboard, float p_seconds, double p_offset, float p_decelerationRatio = 0.9f)
        {
            // Create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(p_seconds)),
                From = new Thickness(0),
                To = new Thickness(-p_offset, 0, p_offset, 0),
                DecelerationRatio = p_decelerationRatio
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // Add this to the storyboard
            p_storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a fade in animation and fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take </param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        public static void AddFadeIn(this Storyboard p_storyboard, float p_seconds)
        {
            // Create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(p_seconds)),
                From = 0,
                To = 1,
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // Add this to the storyboard
            p_storyboard.Children.Add(animation);
        }

        /// <summary>
        /// Adds a fade out animation and fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take </param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        public static void AddFadeOut(this Storyboard p_storyboard, float p_seconds)
        {
            // Create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(p_seconds)),
                From = 1,
                To = 0,
            };

            // Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // Add this to the storyboard
            p_storyboard.Children.Add(animation);
        }
    }
}
