namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Variable objects that represent the variables added to a document or template. Document variables are used to preserve macro settings in between macro sessions.
/// </summary>
public partial interface Variables : InteropObject, InteropCollection<Variable>
{
}
