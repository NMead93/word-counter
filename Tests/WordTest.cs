using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCcounter
{
    public class WordTest
    {
        [Fact]
        public void CountWord_CountWordInOneWordSentenceCaseSensitive_true()
        {
            RepeatCounter testWord = new RepeatCounter("h", "h");
            Assert.Equal(1, testWord.CountRepeats());
        }

        [Fact]
        public void CountWord_CountWordInOneWordSentenceCaseSensitive_true()
        {
            RepeatCounter testWord = new RepeatCounter("h", "h e l l h h");
            Assert.Equal(3, testWord.CountRepeats());
        }

        [Fact]
        public void CountWord_CountWordInOneWordSentenceCaseSensitive_true()
        {
            RepeatCounter testWord = new RepeatCounter("h", "h e l l H H");
            Assert.Equal(3, testWord.CountRepeats());
        }

        [Fact]
        public void CountWord_CountWordInOneWordSentenceCaseSensitive_true()
        {
            RepeatCounter testWord = new RepeatCounter("hello", "Hello");
            Assert.Equal(1, testWord.CountRepeats());
        }

        [Fact]
        public void CountWord_CountWordInOneWordSentenceCaseSensitive_true()
        {
            RepeatCounter testWord = new RepeatCounter("hello", "hello Hello dude");
            Assert.Equal(2, testWord.CountRepeats());
        }

        [Fact]
        public void CountWord_CountWordInOneWordSentenceCaseSensitive_true()
        {
            RepeatCounter testWord = new RepeatCounter("hello", "hello, Hello, dude hello.");
            Assert.Equal(3, testWord.CountRepeats());
        }

    }
}
