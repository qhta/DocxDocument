using DocumentFormat.OpenXml.Office.CoverPageProps;

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AutoEdit;

/// <summary>
/// Contains helper methods for analyzing class declarations.
/// </summary>
public static class AnalyzeHelper
{
  /// <summary>
  /// Checks if the given class declaration syntax node inherits from a generic type and retrieves the argument type name.
  /// The argument type name is extracted from the first type argument of the generic base type.
  /// "DX.OpenXmlElement" is excluded if the type parameter is constrained to it.
  /// </summary>
  /// <param name="classNode"></param>
  /// <param name="argTypeName"></param>
  /// <returns></returns>
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
  /// Gets the base type name of the given class declaration syntax node.
  /// </summary>
  /// <param name="classNode"></param>
  /// <returns></returns>
  public static string? GetBaseTypeName(this ClassDeclarationSyntax classNode)
  {

    // Check if class inherits from ModelElement<T>
    var baseTypeNode = classNode.BaseList?.Types.Select(bt => bt.Type).FirstOrDefault();

    if (baseTypeNode == null)
      return null;

    return baseTypeNode.ToString();
  }
}