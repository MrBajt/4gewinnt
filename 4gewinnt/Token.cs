using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace viergewinnt
{
    class Token :INotifyPropertyChanged
    {
        Position _Position;
        Color _Color;
        public Position Position
        {
            get
            {
                return _Position;
            }
            set
            {
                _Position = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
            }
        }
        public Color Color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
            }
        }

        public Token()
        {

        }

        public Token(Position p)
        {
            Position = p;
        }

        public Token(Position p, Color c)
        {
            Position = p;
            Color = c;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class Position : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        int _x, _y;
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(X)));
            }
        }
            public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Y)));
            }
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
