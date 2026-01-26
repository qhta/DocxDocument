namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of field map data elements for mail merge in a WordprocessingML document.
/// This class provides access to and management of <see cref = "FieldMapData"/> objects, enabling advanced configuration and organization of data source to merge field mappings for mail merge operations.
/// </summary>
[OpenXmlType(typeof(FieldMapData))]
public class FieldMapDataCollection : ElementCollection<FieldMapData>
{
 protected override object? GetUpdatableOpenXmlElement()
 {
  throw new NotImplementedException();
 }
}