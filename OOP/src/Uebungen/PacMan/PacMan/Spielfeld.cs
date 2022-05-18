using PacMan.Spielelemente;
using PacMan.Figuren;
using System.Collections.Generic;

namespace PacMan
{
    internal class Spielfeld
    {
        private List<Wand> _waende;
        private List<Pille> _pillen;
        private PacMann _pacmann;
        private Geist[] _geister;

        public List<Wand> Wand { get { return _waende; } }
        public List<Pille> Pillen { get { return _pillen; } }
        public PacMann PacMan { get { return _pacmann; } }
        public Geist[] Geister { get { return _geister; } }

        public Spielfeld()
        {
            _waende = new List<Wand>();
            _pillen = new List<Pille>();
            _pacmann = new PacMann();
            _geister = new Geist[4];
            _geister[0] = new Geist();
            _geister[1] = new Geist();
            _geister[2] = new Geist();
            _geister[3] = new Geist();
        }
    }
}
