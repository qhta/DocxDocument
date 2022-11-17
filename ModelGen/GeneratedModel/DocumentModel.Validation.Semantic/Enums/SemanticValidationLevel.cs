namespace DocumentModel.Validation.Semantic;

[Flags]
public enum SemanticValidationLevel
{
  PackageOnly,
  PartOnly,
  ElementOnly,
  Package,
  Part,
  Element,
}
