using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assessment;

namespace HPTestAPI
{
    [TestClass]
    public class DeckOfCardTest
    {
        [TestMethod]
        public void createDeck()
        {
            var newCard = new HPdeckOfCards();
            var response  = newCard.CreateCard();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
        }

        [TestMethod]
        public void createDeckWithJoker()
        {
            var newCard = new HPdeckOfCards();
            var response = newCard.CreateCard();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Console.WriteLine(response.deck_id);
        }

        [TestMethod]
        public void drawDeck()
        {
            var card = new HPdeckOfCards();
            var response = card.DrawCard();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Assert.AreEqual("rdtelv6kej9b", response.deck_id);
        }

        [TestMethod]
        public void partialDeck()
        {
        }

        [TestMethod]
        public void shuffleCards()
        {
        }

        [TestMethod]
        public void reShuffleCards()
        {
        }
    }
}
