using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Fasetto.Word.Animation
{
    /// <summary>
    /// Animation helpers for <see cref="StoryBoard"/>
    /// </summary>
    public static class StoryBoardHelpers
    {
        /// <summary>
        /// Adds a slide and fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add the animation to</param>
        /// <param name="seconds">The time the animation will take </param>
        /// <param name="offset">The distance to the right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration</param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f)
        {
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(this.SlideSeconds)),
                From = new Thickness(this.WindowWidth, 0, -this.WindowWidth, 0),
                To = new Thickness(0),
                DecelerationRatio = 0.9f
            };
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            sb.Children.Add(animation);
        }
    }
}
