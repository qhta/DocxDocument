namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Data Model.
/// </summary>
[OpenXmlType(typeof(DXDD.DataModel))]
public class DataModel : ModelElement<DXDD.DataModel>
{
 /// <summary>
 ///   Point List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.PointList))]
 public PointList? PointList { get; set; }

 /// <summary>
 ///   Connection List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.ConnectionList))]
 public ConnectionList? ConnectionList { get; set; }

 /// <summary>
 ///   Background Formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.Background))]
 public Background? Background { get; set; }

 /// <summary>
 ///   Whole E2O Formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.Whole))]
 public Whole? Whole { get; set; }

 /// <summary>
 ///   DataModelExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.DataModelExtensionList))]
 public DataModelExtensionList? DataModelExtensionList { get; set; }
}