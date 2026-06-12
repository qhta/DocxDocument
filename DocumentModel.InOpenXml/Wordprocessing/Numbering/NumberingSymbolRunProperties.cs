namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents run properties for numbering symbols in a WordprocessingML document.
/// This class extends <see cref = "BaseRunProperties{T}"/> and provides additional properties for complex script and right-to-left text formatting, enabling advanced control over the appearance of numbering symbols in lists and outlines.
/// </summary>
[OpenXmlType(typeof(DXW.NumberingSymbolRunProperties))]
[XmlRoot("NumberingSymbolRunProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class NumberingSymbolRunProperties : BaseRunProperties<DXW.NumberingSymbolRunProperties>
{
 /// <summary>
 /// Indicates whether the contents of this run are treated as complex script text regardless of their Unicode character values when determining formatting.
 /// </summary>
 public bool? ComplexScript { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Indicates whether the contents of this run have right-to-left characteristics.
 /// </summary>
 public bool? RightToLeftText { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}