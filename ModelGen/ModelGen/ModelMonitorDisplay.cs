namespace ModelGen;

[Flags]
public enum ShowOptions
{
  AcceptedTypesOnly = 1,
  OriginalNames = 2,
}

public static class ModelMonitorDisplay
{
  public static void ShowNamespaces()
  {
    if (TypeManager.Namespaces.Count > 0)
    {
      var maxNamespaceLength = TypeManager.Namespaces.Max(item => item.Length);
      foreach (var nspace in TypeManager.Namespaces)
      {
        var aSpace = nspace;
        if (aSpace.Length < maxNamespaceLength)
          aSpace = aSpace + new string(' ', maxNamespaceLength - aSpace.Length);
        var nSpaceTypes = TypeManager.KnownTypes.Where(item => item.Value.Namespace == nspace).Select(item => item.Value).ToList();
        var nSpaceTypesCount = nSpaceTypes.Count;
        var nSpaceAcceptedCount = nSpaceTypes.Count(item => item.IsAccepted);
        var nSpaceClassesCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Class);
        var nSpaceEnumsCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Enum);
        var nSpaceSystemCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.System);
        var str = $"{aSpace} {nSpaceTypesCount} types";
        str += $", {AllNone(nSpaceAcceptedCount, nSpaceTypesCount)} accepted";
        if (nSpaceClassesCount != 0)
          str += $", {AllNone(nSpaceClassesCount, nSpaceTypesCount)} {Multi(nSpaceClassesCount, "class")}";
        if (nSpaceEnumsCount != 0)
          str += $", {AllNone(nSpaceEnumsCount, nSpaceTypesCount)} {Multi(nSpaceEnumsCount, "enum")}";
        if (nSpaceSystemCount != 0)
          str += $", {AllNone(nSpaceSystemCount, nSpaceTypesCount)} system";
        Console.WriteLine(str);
      }
    }
  }

  public static void ShowNamespaceDetails(ShowOptions options = 0)
  {
    int count = 0;
    foreach (var nspace in TypeManager.Namespaces.ToList())
    {
      if (count++!=0)
        Console.WriteLine();
      ShowNamespaceDetails(nspace, options);
    }
  }

  public static void ShowNamespaceDetails(string nspace, ShowOptions options = 0)
  {
    var nSpaceTypes = TypeManager.KnownTypes.Where(item => item.Value.Namespace == nspace).Select(item => item.Value).ToList();
    if (options.HasFlag(ShowOptions.AcceptedTypesOnly))
      nSpaceTypes = nSpaceTypes.Where(item => item.IsAccepted).ToList();
    if (nSpaceTypes.Count > 0)
    {
      Console.WriteLine($"namespace {nspace}");
      foreach (var typeInfo in nSpaceTypes)
      {
        if (!typeInfo.IsReflected)
          typeInfo.Reflect();
        var typeStr = $"{(typeInfo.IsAccepted ? "accepted" : "unaccepted")} {typeInfo.TypeKind.ToString().ToLower()} {typeInfo.FullName}";
        if (typeInfo.BaseTypeInfo != null)
          typeStr += $": {typeInfo.BaseTypeInfo.FullName}";
        Console.WriteLine("  "+typeStr);
        if (options.HasFlag(ShowOptions.OriginalNames))
          if (typeInfo.Name != typeInfo.OrigName)
            Console.WriteLine("    "+$"original name: {typeInfo.OrigFullName}");
        if (typeInfo.IsGenericTypeDefinition)
        {
          var genericTypeParams = typeInfo.GetGenericParamTypes();
          if (genericTypeParams != null)
          {
            foreach (var genericTypeParam in genericTypeParams.ToArray())
            {
              var ls = new List<String>();
              var genericTypeParamsConstraints = genericTypeParam.GetGenericTypeParamConstraints();
              if (genericTypeParamsConstraints != null)
                foreach (var item in genericTypeParamsConstraints.ToArray())
                  ls.Add(item.FullName);
              var genericParamConstraints = genericTypeParam.GetGenericParamConstraints();
              if (genericParamConstraints != null)
                foreach (var item in genericParamConstraints.ToArray())
                  ls.Add(item.ToString().ToLower());
              if (ls.Count > 0)
              {
                typeStr += $": where {genericTypeParam.Name}: " + String.Join(", ", ls);
                Console.WriteLine("  " + typeStr);
              }
            }
          }
        }

        //var incomingRels = TypeManager.GetIncomingRelationships(typeInfo).ToList();
        //if (incomingRels.Count > 0)
        //{
        //  Console.WriteLine($"    {incomingRels.Count} incoming {Multi(incomingRels.Count,"relationship")}");
        //  foreach (var rel in incomingRels.Take(10))
        //    Console.WriteLine($"      {rel.Semantics} from {rel.Source.ToString()}");
        //}
        var outgoingRels = TypeManager.GetOutgoingRelationships(typeInfo)
          .Where(item => item.Semantics != Semantics.Inheritance
                         && item.Semantics != Semantics.GenericTypeArg && item.Semantics != Semantics.GenericTypeParam &&
                         item.Semantics != Semantics.GenericTypeParamConstraint
          ).ToList();
        if (outgoingRels.Any())
        {
          Console.WriteLine($"    {outgoingRels.Count} outgoing {Multi(outgoingRels.Count, "relationship")}");
          foreach (var rel in outgoingRels.Take(10))
            Console.WriteLine($"      {rel.Semantics} to {rel.Target.ToString()}");
        }
      }
    }
  }
  private static string AllNone(int n, int cmp) => (n == 0) ? "none" : (n == cmp) ? "all" : n.ToString();

  private static string Multi(int n, string single, string? multi = null) => (n == 1) ? single : (multi ?? (single.EndsWith("s") ? (single + "es") : (single + "s")));

}

