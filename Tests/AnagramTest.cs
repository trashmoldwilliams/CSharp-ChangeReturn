using Xunit;
using AnagramNS.Objects;
using System.Collections.Generic;
using System;

namespace AnagramNS
{
  public class AnagramTest
  {
    [Fact]
    public void CompareWord_ForWord_SeeAnagrams()
    {
      List<string> result = new List<string>(){"beard"};
      Assert.Equal(result, Word.CompareWord("bread"));
    }
  }
}
