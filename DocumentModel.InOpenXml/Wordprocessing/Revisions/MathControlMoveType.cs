namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a tracked move revision for math control elements in a WordprocessingML document.
/// This class provides properties for author, date, and annotation identifier, enabling tracking and management of mathematical content moves within the document.
/// </summary>
[OpenXmlType(typeof(DXW.MathControlMoveType))]
public class MathControlMoveType : IdentifiedChange<DXW.MathControlMoveType>
{
}