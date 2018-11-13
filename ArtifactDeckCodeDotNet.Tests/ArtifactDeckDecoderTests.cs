﻿using Xunit;
using System.Linq;

namespace ArtifactDeckCodeDotNet.Tests
{
    public class ArtifactDeckDecoderTests
    {
        [Fact]
        public void ParseDeckShouldCorrectlyParseDesk ()
        {
            // Act
            Deck deck = ArtifactDeckDecoder.ParseDeck(TestDeckCodes.GreenBlackExample);

            // Verify
            Assert.Equal(5, deck.Heroes.Count);
            Assert.Equal(15, deck.Cards.Count);
            Assert.Equal(51, (deck.Heroes.Count * 3) + deck.Cards.Sum(c => c.Count));
            Assert.Equal("Green/Black Example", deck.Name);

            Assert.Contains(deck.Heroes, x => x.Id == 10014); // Lycan
            Assert.Contains(deck.Heroes, x => x.Id == 10026); // Rix
            Assert.Contains(deck.Heroes, x => x.Id == 10047); // Phantom Assassin
            Assert.Contains(deck.Heroes, x => x.Id == 4005);  // Debbi the Cunning
            Assert.Contains(deck.Heroes, x => x.Id == 10017); // Chen

            Assert.Contains(deck.Cards, x => x.Id == 3000 && x.Count == 2); // Traveler's Cloak
            Assert.Contains(deck.Cards, x => x.Id == 10102 && x.Count == 3); // Thunderhide Pack
        }
    }
}