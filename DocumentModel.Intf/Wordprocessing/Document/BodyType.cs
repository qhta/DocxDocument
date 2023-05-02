namespace DocumentModel.Wordprocessing;

/// <summary>
///   Common class for <see cref="Body"/> and <see cref="DocPartBody"/> elements.
/// </summary>
public abstract class BodyType : Story
{
  /// <summary>
  /// Main constructor.
  /// </summary>
  public BodyType()
  {
    Parent = this;
  }

  /// <summary>
  /// Collection of sections which is recollected from SectionProperties elements
  /// </summary>
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