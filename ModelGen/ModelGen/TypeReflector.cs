using DocumentFormat.OpenXml;

using Namotion.Reflection;

namespace ModelGen;

public record ReflectionInfo
{
  public int? Done;
  public int? Waiting;
  public TypeInfo? Current;
}

public delegate void ReflectionEvent(ReflectionInfo info);

public static class TypeReflector
{
  public static event ReflectionEvent? OnReflection;

  private static Queue<TypeInfo> TypeQueue = new Queue<TypeInfo>();

  public static void ReflectTypeAsync(this TypeInfo typeInfo)
  {
    if (typeInfo.IsReflected)
      return;
    lock (typeInfo)
    {
      if (!TypeQueue.Contains(typeInfo))
        TypeQueue.Enqueue(typeInfo);
      if (!isStarted) Start();
    }
  }

  private static bool isStarted => ReflectionTasks is not null;
  private static int TaskCount = 2;
  private static Task[] ReflectionTasks = null!;
  private static int RunTrials = 100;
  public static void Start()
  {
    ReflectionTasks = new Task[TaskCount];
    for (int i = 0; i < TaskCount; i++)
    {
      ReflectionTasks[i] = new Task(() =>
      {
        var trials = RunTrials;
        do
        {
          trials--;
          if (TypeQueue.Any())
          {
            TypeInfo? typeInfo = null;
            lock (TypeQueue)
            {
              if (TypeQueue.Count > 0)
                typeInfo = TypeQueue.Dequeue();
              else
              {
                typeInfo = null;
              }
            }
            if (typeInfo != null)
            {
              ReflectType(typeInfo);
              trials = RunTrials;
            }
            else
              Thread.Sleep(10);
          }
        } while (trials > 0);
      });
      ReflectionTasks[i].Start();
    }
  }


  public static void WaitDone()
  {
    if (ReflectionTasks is not null)
      while (TypeQueue.Count>0)
        Task.WaitAll(ReflectionTasks, 1000);
  }

  public static void WaitForReflection(this TypeInfo typeInfo)
  {
    int count = 10;
    while (typeInfo.IsReflected == false && (count--) > 0)
    {
      Thread.Sleep(10);
    }
    if (!typeInfo.IsReflected)
      ReflectType(typeInfo);
  }

  public static object reflectedLock = new();
  public static int reflected;
  public static void ReflectType(this TypeInfo typeInfo)
  {
    if (typeInfo.IsReflected)
      return;
    typeInfo.IsReflected = true;
    lock (reflectedLock)
    {
      reflected++;
      OnReflection?.Invoke(new ReflectionInfo{ Done=reflected, Waiting=TypeQueue.Count, Current = typeInfo });
    }
    var type = typeInfo.Type;
    if (type.IsEnum)
    {
      if (typeInfo.EnumValues == null)
        typeInfo.EnumValues = new OwnedCollection<EnumInfo>(typeInfo);
      foreach (var item in type.GetFields(BindingFlags.Static | BindingFlags.Public))
        typeInfo.EnumValues.Add(new EnumInfo(item));
    }
    else if ((type.IsClass || type.IsInterface || type.IsValueType) && type != typeof(string) && type != typeof(object))
    {
      if (typeInfo.Properties == null)
        typeInfo.Properties = new OwnedCollection<PropInfo>(typeInfo);
      foreach (var item in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
      {
        if (!item.PropertyType.Name.EndsWith('&'))
          typeInfo.Properties.Add(new PropInfo(item));
      }
      if (type.BaseType != null && type.BaseType != typeof(object) && type.BaseType != typeof(ValueType))
      {
        typeInfo.BaseTypeInfo = TypeManager.RegisterType(type.BaseType, typeInfo, Semantics.Inheritance);
      }

      if (type.ContainsGenericParameters)
      {
        var genericTypeParameters = type.GetGenericArguments();
        if (genericTypeParameters.Any())
        {
          foreach (var argType in genericTypeParameters)
            TypeManager.RegisterType(argType, typeInfo, Semantics.GenericTypeParam);
        }
      }

      if (type.IsGenericTypeParameter)
      {
        var genericTypeParamConstraints = type.GetGenericParameterConstraints();
        if (genericTypeParamConstraints.Any())
        {
          foreach (var constraint in genericTypeParamConstraints)
            TypeManager.RegisterType(constraint, type, Semantics.GenericTypeParamConstraint);
        }
      }

      var genericTypeArguments = type.GenericTypeArguments;
      if (genericTypeArguments.Any())
      {
        int cnt = 0;
        foreach (var argType in genericTypeArguments)
        {
          var argTypeInfo = TypeManager.RegisterType(argType);
          var rel = TypeManager.AddRelationship(typeInfo, argTypeInfo, Semantics.GenericTypeArg, ++cnt);
        }
      }

      var implementedInterfaces = type.GetInterfaces();
      if (implementedInterfaces.Any())
      {
        foreach (var intf in implementedInterfaces)
        {
          TypeManager.RegisterType(intf, typeInfo, Semantics.Implementation);
        }
      }
    }

    typeInfo.Documentation = type.GetXmlDocsElement();
    if (typeInfo.Documentation != null)
    {
      typeInfo.Summary = DocumentationReader.GetSummaryFirstPara(typeInfo.Documentation);
      //var childItemTypes = DocumentationReader.GetChildItemTypes(typeInfo.Documentation, type.Assembly);
      //if (childItemTypes != null)
      //{
      //  foreach (var childItemType in childItemTypes)
      //    TypeManager.RegisterType(childItemType, typeInfo, Semantics.Include);
      //}
    }

    TypeInspector.InspectType(typeInfo);

    if (typeInfo.ItemsConstraint != null)
      IncludeProperties(typeInfo, typeInfo.ItemsConstraint);
    /*
    else
    {
      foreach (var includeRelationship in typeInfo.GetOutgoingRelationships(Semantics.Include))
      {
        if (typeInfo.Properties == null)
          typeInfo.Properties = new OwnedCollection<PropInfo>(typeInfo);
        if (includeRelationship.IsMultiple == true)
        {
          var propName = MultipleItemsPropName(includeRelationship.Target.Name);
          if (typeInfo.Name == propName)
            propName = "Items";
          if (!typeInfo.Properties.Any(item => item.Name == propName))
          {
            var propInfo = new PropInfo(includeRelationship.Target);
            propInfo.Name = propName;
            Type propertyType = typeof(System.Collections.ObjectModel.Collection<>).MakeGenericType(new Type[] { includeRelationship.Target.Type });
            propInfo.PropertyType = TypeManager.RegisterType(propertyType);
            typeInfo.Properties.Add(propInfo);
          }
        }
        else
        {
          var propName = includeRelationship.Target.Name;
          if (typeInfo.Name == propName)
            propName = "Child" + propName;
          if (!typeInfo.Properties.Any(item => item.Name == propName))
          {
            var propInfo = new PropInfo(includeRelationship.Target);
            propInfo.Name = propName;
            typeInfo.Properties.Add(propInfo);
          }
        }
      }
    }
*/
    //foreach (var item in type.CustomAttributes)
    //  typeInfo.CustomAttributes.Add(new CustomAttribData(item));
  }

  public static void IncludeProperties(this TypeInfo typeInfo, ItemsConstraint constraint)
  {
    if (typeInfo.Name == "DocParts")
      Debug.Assert(true);
    if (constraint is ItemTypeConstraint typeConstraint)
    {
      typeConstraint.AccessProperty = CreateProperty(typeInfo, typeConstraint);
    }
    else if (constraint is ItemsCompoundConstraint compoundConstraint)
      foreach (var itemConstraint in compoundConstraint.Items)
        IncludeProperties(typeInfo, itemConstraint);
  }

  public static PropInfo? CreateProperty(this TypeInfo typeInfo, ItemTypeConstraint constraint)
  {
    if (typeInfo.Properties == null)
      typeInfo.Properties = new OwnedCollection<PropInfo>(typeInfo);
    var targetType = constraint.ItemType;
    if (constraint.IsMultiple)
    {
      var propName = PluralizeName(targetType.Name);
      if (typeInfo.Name == propName)
        propName = "Items";
      var existingProp = typeInfo.Properties.FirstOrDefault(item => item.Name == propName);
      if (existingProp == null)
      {
        var propInfo = new PropInfo(propName, targetType);
        Type propertyType = typeof(System.Collections.ObjectModel.Collection<>).MakeGenericType(new Type[] { targetType.Type });
        if (constraint.MaxCount != null || constraint.MinCount!= null)
        {
          propInfo.CustomAttributes.Add(new CustomAttribInfo(
            new DocumentModel.Attributes.CollectionConstraintAttribute
          { 
            MinCount = constraint.MinCount,
            MaxCount = constraint.MaxCount,
          }));
        }
        propInfo.PropertyType = TypeManager.RegisterType(propertyType);
        propInfo.IsConstrained = true;
        typeInfo.Properties.Add(propInfo);
        return propInfo;
      }
      else
      {
        existingProp.IsConstrained = true;
        return existingProp;
      }
    }
    else
    {
      var propName = targetType.Name;
      if (typeInfo.Name == propName)
        propName = "Child" + propName;
      var existingProp = typeInfo.Properties.FirstOrDefault(item => item.Name == propName);
      if (existingProp == null)
      {
        var propInfo = new PropInfo(propName, targetType);
        propInfo.IsConstrained = true;
        typeInfo.Properties.Add(propInfo);
        return propInfo;
      }
      else
      {
        existingProp.IsConstrained = true;
        return existingProp;
      }
    }
    //return null;
  }

  public static string PluralizeName(string aName)
  {
    if (aName.EndsWith("y"))
      return aName.Substring(0, aName.Length - 1) + "ies";
    else if (aName.EndsWith("ss"))
      return aName + "es";
    if (!aName.EndsWith("s"))
      return aName + "s";
    return aName;
  }

  public static string SingularizeName(string aName)
  {
    if (aName.EndsWith("ies"))
      return aName.Substring(0, aName.Length - 3) + "y";
    else if (aName.EndsWith("sses"))
      return aName.Substring(0, aName.Length - 2);
    else if (aName.EndsWith("s"))
      return aName.Substring(0, aName.Length - 1);
    else return aName;
  }

  private static bool GenDocumentationComments(TypeInfo typeInfo)
  {
    var documentation = typeInfo.Type.GetXmlDocsElement();
    if (documentation != null)
    {
      var summary = DocumentationReader.GetSummaryFirstPara(documentation);
      typeInfo.Summary = summary;
      return true;
    }
    return false;
  }
}