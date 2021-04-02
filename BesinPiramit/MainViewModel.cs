using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BesinPiramit
{
   public class MainViewModel
    {

        public MainViewModel() => Show = new RelayCommand<object>(parameter => (parameter as Path).Fill = Brushes.Transparent, parameter => true);

        public ICommand Show { get; }

    }
}
