// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Example.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Example type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CleanCode {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// The example 1.
    /// </summary>
    public class Example {


        #region Nom Significatif
        /// <summary>
        /// The get them.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<int[]> GetThem() {
            var list1 = new List<int[]>();
            foreach (int[] ints in list1) {
                if (ints[0] == 4) {
                    list1.Add(ints);
                }
            }
            return list1;
        }
        #endregion

        #region Principe de la Responsabilité Unique

        /// <summary>
        /// The is comestible.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsComestible() {
            if (this.DateExpiration > new DateTime() && this.ApprouverPourConsomer == true
                && this.InspectectionId != null) {
                return true;
            } else {
                return false;
            }
        }

        #region hide
        protected object InspectectionId { get; private set; }

        protected bool ApprouverPourConsomer { get; private set; }

        protected DateTime DateExpiration { get; private set; }

        #endregion
        #endregion

        #region Ne pas mélanger les niveaux d'abstration

        public void FaitLeMenage() {
            JetteLaPoubelle();
            PromeneLeChien();

            foreach (Vaisselle vaisselle in pilleDeVaisselleSalle) {
                evier.NettoyeVaisselle(vaisselle);
                linge.SeicheVaisselle(vaisselle);
            }
        }
        #region hide
        private void PromeneLeChien() {
            throw new NotImplementedException();
        }

        private void JetteLaPoubelle() {
            throw new NotImplementedException();
        }

        public class Vaisselle {
        }

        public class Evier {
            public void NettoyeVaisselle(Vaisselle vaisselle) {
                throw new NotImplementedException();
            }
        }

        public class Linge {
            public void SeicheVaisselle(Vaisselle vaisselle) {
                throw new NotImplementedException();
            }
        }

        private IEnumerable<Vaisselle> pilleDeVaisselleSalle;
        private Evier evier;
        private Linge linge;
        #endregion
        #endregion
        
#region Separer les commandes et les requêtes
        public class Voiture
        {
            private bool demarer;

            public void Demarer()
            {
                demarer = true;
            }

            public bool IsDemarer()
            {
                return demarer;
            }
        }


#endregion

#region Utiliser les exceptions
        public int Foo(string s)
        {
            return 0; 
        }

        public void Bar()
        {
            if (this.Foo("") == OK)
            {

            }
            else
            {
                
            }
        }

        protected int OK { get; set; }

        #endregion

        #region Ne pas répéter
            public void Bar2()
            {
                this.Foo("A");
                this.Foo("B");
                this.Foo("C");
            }
        #endregion

    }
}
