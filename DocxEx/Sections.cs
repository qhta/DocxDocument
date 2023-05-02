namespace DocumentModel;

/// <summary>
/// Collection of <see cref="Section"/> elements.
/// </summary>
public class Sections: ElementCollection<Section>
{
  /// <summary>
  /// Constructor based on wordprocessing document body.
  /// </summary>
  /// <param name="body"></param>
  public Sections(DXW.Body body)
  {
    var sectionRanges = body.GetSections();
    foreach (var sectionRange in sectionRanges) 
      Add(new Section(sectionRange));
  }

  /// <summary>
  /// Cleans selected section properties.
  /// </summary>
  /// <param name="mask">Select properties to clean</param>
  public void CleanProperties(SectionPropertyMask mask = SectionPropertyMask.All)
  {
    foreach (var section in this) 
      section.CleanProperties(mask);
  }

}
