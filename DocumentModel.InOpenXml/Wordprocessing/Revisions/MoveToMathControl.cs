namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a tracked move-to revision for math control elements in a WordprocessingML document.
/// This class provides properties for run formatting, inserted math control, and deleted math control, enabling revision tracking and management of mathematical content moves within the document.
/// </summary>
[OpenXmlType(typeof(DXW.MoveToMathControl))]
public partial class MoveToMathControl : ModelElement<DXW.MoveToMathControl>
{
 /// <summary>
 /// Run properties for the moved math control, specifying character-level formatting.
 /// </summary>
 [OpenXmlElement(typeof(DXW.MoveToMathControl))]
 public RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }

 private RunProperties? _RunProperties;
 /// <summary>
 /// Inserted math control revision information, tracking newly added mathematical content.
 /// </summary>
 [OpenXmlElement(typeof(DXW.MoveToMathControl))]
 public InsertedMathControl? InsertedMathControl { get => _InsertedMathControl; set => UpdateField(ref _InsertedMathControl, value, nameof(InsertedMathControl)); }

 private InsertedMathControl? _InsertedMathControl;
 /// <summary>
 /// Deleted math control revision information, tracking removed mathematical content.
 /// </summary>
 [OpenXmlElement(typeof(DXW.MoveToMathControl))]
 public DeletedMathControl? DeletedMathControl { get => _DeletedMathControl; set => UpdateField(ref _DeletedMathControl, value, nameof(DeletedMathControl)); }

 private DeletedMathControl? _DeletedMathControl;
}