namespace DocumentModel.Wordprocessing;

/// <summary>
///   Common class for <see cref="Body"/> and <see cref="DocPartBody"/> elements.
/// </summary>
public abstract class BodyType : Story, IModelElement<DXW.BodyType>
{
  /// <summary>
  /// Main constructor.
  /// </summary>
  public BodyType()
  {
    Parent = this;
  }

  /// <summary>
  /// Main constructor.
  /// </summary>
  public BodyType(DXW.BodyType element)
  {
    Element = element;
  }

  /// <summary>
  /// Wrapped OpenXml element.
  /// </summary>
  public DXW.BodyType Element { get; private set; } = null!;

  /// <summary>
  /// Collection of sections which is recollected from SectionProperties elements
  /// </summary>
  [NonComparable]
  [XmlIgnore]
  public SectionsCollection Sections
  {
    get
    {
      if (_Sections == null)
        _Sections = SectionsCollection.Create(this);
      return _Sections;
    }
  }
  private SectionsCollection? _Sections;

  /// <summary>
  /// Reloads items from OpenXml element.
  /// </summary>
  public void Reload()
  {

  }
}