using ScreenSoundDesktop.Context;

namespace ScreenSoundDesktop
{
    public partial class Principal : Form
    {
        private readonly ScreenSoundContext _context;

        public Principal(ScreenSoundContext context) // Construtor com injeção de dependência
        {
            _context = context;
            InitializeComponent();
        }
    }
}
