namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the contents of the body of the document - the main document editing surface.
///   The document body contains what is referred to as block-level markup - 
///   markup which can exist as a sibling element to paragraphs in a document.
/// </summary>
public class Body : ElementCollection<IBodyElement>
{
  public Body()
  {
    Parent = this;
  }

  [NonComparable]
  [XmlIgnore] public SectionsCollection? Sections
  {
    get 
    {
      if (_Sections == null)
        _Sections = SectionsCollection.Create(this);
      return _Sections;
    }
    //set { }
  }
  private SectionsCollection? _Sections;
}