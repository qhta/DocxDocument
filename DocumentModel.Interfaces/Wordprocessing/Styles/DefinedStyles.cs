using System.Diagnostics.CodeAnalysis;
namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
public partial interface DefinedStyles : ElementCollection<Style>
{
  public IEnumerable<Style> ParagraphStyles
  {
    get;
    set;
  }
  public IEnumerable<Style> CharacterStyles
  {
    get;
    set;
  }
  public IEnumerable<Style> TableStyles
  {
    get;
    set;
  }
  public IEnumerable<Style> NumberingStyles
  {
    get;
    set;
  }
}