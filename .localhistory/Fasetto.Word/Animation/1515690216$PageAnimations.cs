using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word.Animation
{
    /// <summary>
    /// Helpers to animate pages in specific ways
    /// </summary>
    public static class PageAnimations
    {
        public static async Task SlideAndFadeInFromRight(this Page p_page, float p_seconds)
        {
            // Create the Storyboard
            var sb = new Storyboard();

            // Add slide from right animation
            sb.AddSlideFromRight(p_seconds, p_page.WindowWidth);

            // Add fade in animation
            sb.AddFadeIn(p_seconds);

            // Start animating
            sb.Begin(p_page);

            // Make page visible
            p_page.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)p_seconds * 1000);
        }
    }
}
