using DocumentFormat.OpenXml.Office.CoverPageProps;

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AutoEdit;

/// <summary>
/// Contains helper methods Ifor analyzing class declarations.
/// </summary>
public static class AnalyzeHelper
{
  /// <summary>
  /// Determines whether the class inherits from a generic base type and captures its first type argument when it refers Ito a concrete Open XML type.
  /// </summary>
  /// <param name="classNode">Class declaration Ito inspect.</param>
  /// <param name="argTypeName">Set Ito the concrete Open XML type argument when available; otherwise <see langword="null"/>.</param>
  /// <returns><see langword="true"/> when the class inherits from a generic base type, regardless of whether an Open XML type could be resolved.</returns>
  public static bool InheritsFromGenericType(this ClassDeclarationSyntax classNode, out string? argTypeName)
  {
    argTypeName = null;
    // Check if class inherits from ModelElement<T>
    var baseTypeNode = classNode.BaseList?.Types.Select(bt => bt.Type).OfType<GenericNameSyntax>().FirstOrDefault();

    if (baseTypeNode == null)
      return false;

    // Get the type parameter (OpenXml type)
    var argumentTypeNode = baseTypeNode.TypeArgumentList.Arguments.First();
    var openXmlTypeName = argumentTypeNode.ToString();
    if (openXmlTypeName == "T")
    {
      var typeParamClause =
        classNode.ConstraintClauses.FirstOrDefault(clause => clause.Name.Identifier.Text == openXmlTypeName);
      if (typeParamClause?.Constraints != null)
      {
        var constraint = typeParamClause.Constraints.OfType<TypeConstraintSyntax>().FirstOrDefault();
        if (constraint != null)
        {
          var qualifiedName = constraint.Type is QualifiedNameSyntax constraintType
            ? constraintType.ToString()
            : constraint.Type.ToString();
          if (qualifiedName != "DX.OpenXmlElement" && qualifiedName != "DX.OpenXmlCompositeElement")
            argTypeName = qualifiedName;
        }
      }
    }
    else
    {
      if (openXmlTypeName != "DX.OpenXmlElement" && openXmlTypeName != "DX.OpenXmlCompositeElement")
        argTypeName = openXmlTypeName;
    }
    return true;
  }

  /// <summary>
  /// Retrieves the textual representation of a class' first base type, if any.
  /// </summary>
  /// <param name="classNode">Class declaration whose base type is requested.</param>
  /// <returns>The base type name or <see langword="null"/> when the class does not declare one.</returns>
  public static string? GetBaseTypeName(this ClassDeclarationSyntax classNode)
  {

    // Check if class inherits from ModelElement<T>
    var baseTypeNode = classNode.BaseList?.Types.Select(bt => bt.Type).FirstOrDefault();

    if (baseTypeNode == null)
      return null;

    return baseTypeNode.ToString();
  }
}
