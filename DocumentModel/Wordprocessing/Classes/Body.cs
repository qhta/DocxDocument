namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Body Class.
/// </summary>
public class Body : ElementCollection<IBodyElement>
{
  public Body()
  {
    Parent = this;
  }

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