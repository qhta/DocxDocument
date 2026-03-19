namespace DocumentModel.Interop.Word;

public partial interface XMLSchemaReferences
{
  /// <summary>
  /// Verifies an individual XML element or the entire document against the attached XML schema or schemas.
  /// </summary>
  public void Validate();
}
