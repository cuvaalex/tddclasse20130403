namespace Com.Zenika.TDD {
    using FluentAssertions;

    using NUnit.Framework;

    /// <summary>
    /// The add test.
    /// </summary>
    [TestFixture]
    public class CalculateurTest {
        /// <summary>
        /// The quand adition 5 et 4 alors egal 9.
        /// </summary>
        [Test]
        public void QuandAdition5Et4AlorsEgal9()
        {
            var valeur1 = 5;
            var valeur2 = 4;
            var expected = 9;

            var calculateur = new Calculateur();
            var resultat = calculateur.Add(valeur1, valeur2);

            resultat.Should().BePositive("Ajout de 2 chiffre positif donne un chiffre positif").And.Be(expected);
        }
    }

}
