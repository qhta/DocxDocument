namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents style table properties for a table in a Wordprocessing document.
/// This class provides properties for row and column band sizes, enabling advanced table styling and formatting options.
/// </summary>
[OpenXmlType(typeof(DXW.StyleTableProperties))]
[XmlRoot("StyleTableProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class StyleTableProperties : BaseTableProperties<DXW.StyleTableProperties>
{
 /// <summary>
 /// Table style row band size, specifying the number of rows in each band for table styling.
 /// </summary>
 public Int32? TableStyleRowBandSize { get; set; }
 /// <summary>
 /// Table style column band size, specifying the number of columns in each band for table styling.
 /// </summary>
 public Int32? TableStyleColumnBandSize { get; set; }
}