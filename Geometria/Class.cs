using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public Rettangolo (int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        public int CalcolaArea(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            int areaRettangolo = baseRettangolo * altezzaRettangolo;
            return areaRettangolo;
        }

        public int CalcolaPerimetro(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
            int perimetroRettangolo = 2 * (baseRettangolo + altezzaRettangolo);
            return perimetroRettangolo;
        }
    }



    // ---------- Secondo Rettangolo ----------



    internal class RettangoloDue
    {
        public int baseRettangoloDue;
        public int altezzaRettangoloDue;

        public RettangoloDue(int baseRettangoloDue, int altezzaRettangoloDue)
        {
            this.baseRettangoloDue = baseRettangoloDue;
            this.altezzaRettangoloDue = altezzaRettangoloDue;
        }

        public int CalcolaAreaDue(int baseRettangoloDue, int altezzaRettangoloDue)
        {
            this.baseRettangoloDue = baseRettangoloDue;
            this.altezzaRettangoloDue = altezzaRettangoloDue;
            int areaRettangoloDue = baseRettangoloDue * altezzaRettangoloDue;
            return areaRettangoloDue;
        }

        public int CalcolaPerimetroDue(int baseRettangoloDue, int altezzaRettangoloDue)
        {
            this.baseRettangoloDue = baseRettangoloDue;
            this.altezzaRettangoloDue = altezzaRettangoloDue;
            int perimetroRettangoloDue = 2 * (baseRettangoloDue + altezzaRettangoloDue);
            return perimetroRettangoloDue;
        }
    }



    // ----------- Terzo Rettangolo -----------



    internal class RettangoloTre
    {
        public int baseRettangoloTre;
        public int altezzaRettangoloTre;

        public RettangoloTre(int baseRettangoloTre, int altezzaRettangoloTre)
        {
            this.baseRettangoloTre = baseRettangoloTre;
            this.altezzaRettangoloTre = altezzaRettangoloTre;
        }

        public int CalcolaAreaTre(int baseRettangoloTre, int altezzaRettangoloTre)
        {
            this.baseRettangoloTre = baseRettangoloTre;
            this.altezzaRettangoloTre = altezzaRettangoloTre;
            int areaRettangoloTre = baseRettangoloTre * altezzaRettangoloTre;
            return areaRettangoloTre;
        }

        public int CalcolaPerimetroTre(int baseRettangoloTre, int altezzaRettangoloTre)
        {
            this.baseRettangoloTre = baseRettangoloTre;
            this.altezzaRettangoloTre = altezzaRettangoloTre;
            int perimetroRettangoloTre = 2 * (baseRettangoloTre + altezzaRettangoloTre);
            return perimetroRettangoloTre;
        }

    }

        // ---------- Quarto Rettangolo ----------



        internal class RettangoloQuattro
        {
            public int baseRettangoloQuattro;
            public int altezzaRettangoloQuattro;

            public RettangoloQuattro(int baseRettangoloQuattro, int altezzaRettangoloQuattro)
            {
                this.baseRettangoloQuattro = baseRettangoloQuattro;
                this.altezzaRettangoloQuattro = altezzaRettangoloQuattro;
            }

            public int CalcolaAreaQuattro(int baseRettangoloQuattro, int altezzaRettangoloQuattro)
            {
                this.baseRettangoloQuattro = baseRettangoloQuattro;
                this.altezzaRettangoloQuattro = altezzaRettangoloQuattro;
                int areaRettangoloQuattro = baseRettangoloQuattro * altezzaRettangoloQuattro;
                return areaRettangoloQuattro;
            }

            public int CalcolaPerimetroQuattro(int baseRettangoloQuattro, int altezzaRettangoloQuattro)
            {
                this.baseRettangoloQuattro = baseRettangoloQuattro;
                this.altezzaRettangoloQuattro = altezzaRettangoloQuattro;
                int perimetroRettangoloQuattro = 2 * (baseRettangoloQuattro + altezzaRettangoloQuattro);
                return perimetroRettangoloQuattro;
            }
        }
    
}
