using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viergewinnt
{
    class viergewinntModel
    {
        ObservableCollection<Token> _Tokens = new ObservableCollection<Token>();
        public ObservableCollection<Token> Tokens
        {
            get
            {
                return _Tokens;
            }
            set
            {
                _Tokens = value;
            }
        }
    }
}
