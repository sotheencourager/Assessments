using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assessment;

namespace HPTestAPI
{
    [TestClass]
    public class DeckOfCardTest
    {
        string deck_id;

        [TestInitialize]
        public void createDk()
        {
            var newCard = new HPdeckOfCards();
            var response  = newCard.CreateCard();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Console.WriteLine(response.deck_id);
            deck_id = response.deck_id.ToString();
            
        }

        [TestCleanup]
        public void testClean()
        {
            deck_id = null;
            Console.WriteLine("Test is completed and resource cleaned.");
        }

        [TestMethod]
        public void TestCase()
        {
            createDeck();
            drawDeck();
            partialDeck();
            reShuffleCards();
            shuffleCards();
        }

        [TestMethod]
        public void createDeck()
        {
            var newCard = new HPdeckOfCards();
            var response = newCard.CreateCard();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Console.WriteLine(response.deck_id);
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
            var response = card.DrawCard(deck_id);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Assert.AreEqual(deck_id, response.deck_id);
            Console.WriteLine(response.Success);
        }

        [TestMethod]
        public void partialDeck()
        {
            var card = new HPdeckOfCards();
            var response = card.DrawCard(deck_id);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Assert.AreEqual(deck_id, response.deck_id);
            Console.WriteLine(response.Success);
        }

        [TestMethod]
        public void shuffleCards()
        {
            var card = new HPdeckOfCards();
            var response = card.shuffleCards(deck_id);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Console.WriteLine(response.deck_id);
        }

        [TestMethod]
        public void reShuffleCards()
        {
            //string deck_id = createDk();
            var card = new HPdeckOfCards();
            var response = card.reShuffleCards(deck_id);
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Success);
            Console.WriteLine(response.deck_id);
        }
    }
}
