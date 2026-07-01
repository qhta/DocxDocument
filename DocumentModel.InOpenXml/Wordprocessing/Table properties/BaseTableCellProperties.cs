namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for all TableCellProperties classes.
/// Contains common properties for table cell formatting, including shading, text wrapping, margins, and vertical alignment.
/// </summary>
[OpenXmlType(typeof(DXW.TableCellProperties))]
[DataContract]
[XmlRoot("BaseTableCellProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class BaseTableCellProperties<T> : ModelElement<T> where T : DX.OpenXmlElement
{
 static BaseTableCellProperties()
 {
  TableMeasureOpenXmlConverter.RegisterOpenXmlConversion();
 }

 /// <summary>
 /// Shading applied to the table cell, specifying background and pattern formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.Shading))]
 public Shading? Shading { get => _Shading; set => UpdateField(ref _Shading, value, nameof(Shading)); }
 private Shading? _Shading;

 /// <summary>
 /// Indicates whether text wrapping is disabled for the cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.NoWrap))]
 public bool? NoWrap { get => _NoWrap; set => UpdateField(ref _NoWrap, value, nameof(NoWrap)); }
 private bool? _NoWrap;

 /// <summary>
 /// Margins for the table cell, specifying padding on each side.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.TableCellMargin))]
 public TableCellMargin? TableCellMargin { get => _TableCellMargin; set => UpdateField(ref _TableCellMargin, value, nameof(TableCellMargin)); }
 private TableCellMargin? _TableCellMargin;

 /// <summary>
 /// Vertical alignment of content within the table cell.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableCellProperties.TableCellVerticalAlignment))]
 public TableVerticalAlignment? TableCellVerticalAlignment { get => _TableCellVerticalAlignment; set => UpdateField(ref _TableCellVerticalAlignment, value, nameof(TableCellVerticalAlignment)); }
 private TableVerticalAlignment? _TableCellVerticalAlignment;
}

/// <summary>
/// Concrete implementation of BaseTableCellProperties for the default Open XML SDK TableCellProperties class.
/// </summary>
[DataContract]
[XmlRoot("BaseTableCellProperties", Namespace = "DocumentModel.Wordprocessing")]
public class BaseTableCellProperties : BaseTableCellProperties<DXW.TableCellProperties>
{
}