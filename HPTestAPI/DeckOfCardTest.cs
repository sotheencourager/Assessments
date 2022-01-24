using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assessment;

namespace HPTestAPI
{
    [TestClass]
    public class DeckOfCardTest
    {
        [TestMethod]
        public static string createDeck()
        {
            var newCard = new HPdeckOfCards();
            var response  = newCard.CreateCard();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Console.WriteLine(response.deck_id);
            string dId = response.deck_id.ToString();
            return dId;
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
            var card = new HPdeckOfCards();
            var response = card.shuffleCards();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Console.WriteLine(response.deck_id);
        }

        [TestMethod]
        public void reShuffleCards()
        {
            string deck_id = createDeck();
            var card = new HPdeckOfCards();
            var response = card.reShuffleCards(deck_id);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Console.WriteLine(response.deck_id);
        }
    }
}
