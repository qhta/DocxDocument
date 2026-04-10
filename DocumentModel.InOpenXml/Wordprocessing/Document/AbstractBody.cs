namespace DocumentModel.Wordprocessing;
/// <summary>
/// Common interface for <see cref = "Body"/> and <see cref = "DocPartBody"/> elements in a WordprocessingML document.
/// This class extends <see cref = "IStory"/> and provides a property for accessing the collection of sections, which is recollected from <see cref = "ISectionProperties"/> elements, enabling advanced organization and management of document structure and section content.
/// </summary>
[OpenXmlType(typeof(DXW.BodyType))]
public abstract partial class AbstractBody<T> : Story<T> where T : DXW.BodyType
{
  /// <summary>
  /// Collection of sections, recollected from <see cref = "ISectionProperties"/> elements within the document body.
  /// </summary>
  public Sections? Sections { get; set; }

}