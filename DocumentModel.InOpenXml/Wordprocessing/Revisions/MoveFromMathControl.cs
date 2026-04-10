namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a tracked move-from revision for math control elements in a WordprocessingML document.
/// This class provides properties for run formatting, inserted math control, and deleted math control, enabling revision tracking and management of mathematical content moves away from the current location within the document.
/// </summary>
[OpenXmlType(typeof(DXW.MoveFromMathControl))]
[XmlRoot("MoveFromMathControl", Namespace = "DocumentModel.Wordprocessing")]
public partial class MoveFromMathControl : ModelElement<DXW.MoveFromMathControl>
{
 /// <summary>
 /// Run properties for the moved-from math control, specifying character-level formatting.
 /// </summary>
 public RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }

 private RunProperties? _RunProperties;
 /// <summary>
 /// Inserted math control revision information, tracking newly added mathematical content.
 /// </summary>
 public InsertedMathControl? InsertedMathControl { get => _InsertedMathControl; set => UpdateField(ref _InsertedMathControl, value, nameof(InsertedMathControl)); }

 private InsertedMathControl? _InsertedMathControl;
 /// <summary>
 /// Deleted math control revision information, tracking removed mathematical content.
 /// </summary>
 public DeletedMathControl? DeletedMathControl { get => _DeletedMathControl; set => UpdateField(ref _DeletedMathControl, value, nameof(DeletedMathControl)); }

 private DeletedMathControl? _DeletedMathControl;
}