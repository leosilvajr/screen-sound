using ScreenSoundDesktop.Context;

namespace ScreenSoundDesktop
{
    public partial class Principal : Form
    {
        private readonly ScreenSoundContext _context;

        public Principal(ScreenSoundContext context) // Construtor com inje��o de depend�ncia
        {
            _context = context;
            InitializeComponent();
        }
    }
}
