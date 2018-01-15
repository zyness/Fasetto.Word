using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// The MonitorPassword attached property for a <see cref="PasswordBox"/>
    /// </summary>
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;

            if (passwordBox == null)
                return;

            passwordBox.PasswordChanged -= PasswordBOx_PasswordChanged;

            if ((bool)e.NewValue)
            {
                passwordBox.PasswordChanged += PasswordBOx_PasswordChanged;
            }
                
        }

        private void PasswordBOx_PasswordChanged(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// The HasText attached Property for a <see cref="PasswordBox"/>
    /// </summary>
    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool> { }
}
