namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of list entry form fields for a drop-down list in a WordprocessingML document.
/// This class provides access to and management of <see cref = "ListEntryFormField"/> objects, enabling advanced configuration and organization of selectable options within interactive drop-down lists in forms and documents.
/// </summary>
[OpenXmlType(typeof(ListEntryFormField))]
[DataContract]
[XmlRoot("ListEntryFormFields", Namespace = "DocumentModel.Wordprocessing")]
public class ListEntryFormFields : ModelElementCollection<ListEntryFormField, DX.OpenXmlCompositeElement, DXW.ListEntryFormField>
{
  /// <summary>
  /// Initializes a new instance of the ListEntryFormFields collection with default settings.
  /// </summary>
  /// <param name="parent"></param>
  /// <param name="openXmlElement"></param>
  public ListEntryFormFields(ModelElement parent, DX.OpenXmlCompositeElement? openXmlElement) : base(parent, openXmlElement)
  {
  }
}