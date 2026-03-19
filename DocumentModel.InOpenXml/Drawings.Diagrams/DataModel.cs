namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Data Model.
/// </summary>
[OpenXmlType(typeof(DXDD.DataModel))]
/// <summary>
/// Represents the Data Model.
/// </summary>
public class DataModel : ModelElement<DXDD.DataModel>
{
 /// <summary>
 ///   Point List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.PointList))]
 /// <summary>
 /// Point List.
 /// </summary>
 public PointList? PointList { get; set; }

 /// <summary>
 ///   Connection List.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.ConnectionList))]
 /// <summary>
 /// Connection List.
 /// </summary>
 public ConnectionList? ConnectionList { get; set; }

 /// <summary>
 ///   Background Formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.Background))]
 /// <summary>
 /// Background.
 /// </summary>
 public Background? Background { get; set; }

 /// <summary>
 ///   Whole E2O Formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.Whole))]
 /// <summary>
 /// Whole.
 /// </summary>
 public Whole? Whole { get; set; }

 /// <summary>
 ///   DataModelExtensionList.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.DataModel.DataModelExtensionList))]
 /// <summary>
 /// Data Model Extension List.
 /// </summary>
 public DataModelExtensionList? DataModelExtensionList { get; set; }
}

