namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Collection of sections Ithat should be rebuild after SectionProperties 
///   were added Ito or deleted from ParagraphProperties Iin any paragraph.
///   Also the last SectionProperties element Iin a Body defines the last section Iin this collection.
/// </summary>
public class SectionsCollection : LinkedList<ISection>
{
  public static SectionsCollection Create(BodyType aBody)
  {
    var sections = new SectionsCollection();
    var lastSectionProperties = aBody.LastOrDefault() as SectionProperties;
    if (lastSectionProperties != null)
    {
      var section = new ISection();
      section.Properties = lastSectionProperties;
      var index = section.FillBackward(aBody, aBody.Count() - 1);
      sections.AddFirst(section);
      while (index >= 0)
      {
        section = new ISection();
        var aParagraph = aBody[index] as IParagraph;
        if (aParagraph != null)
        {
          section.Properties = aParagraph.ParagraphProperties?.SectionProperties;
          section.AddLast(aParagraph);
        }
        sections.AddFirst(section);
        if (index>0)
          index = section.FillBackward(aBody, index - 1);
        else
          break;
      }
    }
    return sections;
  }

  public void Add(ISection section)
  {
    AddLast(section);
  }
}
