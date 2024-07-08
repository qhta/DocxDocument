using System.Diagnostics;
using System.Runtime.InteropServices;

using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Access;
using Microsoft.Office.Interop.Access.Dao;

using Access = Microsoft.Office.Interop.Access;
using Dao = Microsoft.Office.Interop.Access.Dao;
using Qhta.Access.Dao;

namespace ModelXmlSchema;

public sealed class XmlSchemaDbContext : DbContext
{
  public DbSet<XsdFile> Files { get; set; }

  public DbSet<Namespace> Namespaces { get; set; }

  public DbSet<UsedNamespace> UsedNamespaces { get; set; }

  public DbSet<TypeDef> Types { get; set; }

  public DbSet<EnumValue> EnumValues { get; set; }

  public DbSet<Pattern> Patterns { get; set; }

  public DbSet<UnionMember> UnionMembers { get; set; }

  public DbSet<ListItem> ListItems { get; set; }

  public DbSet<AttributeBase> Attributes { get; set; }

  public DbSet<AttributeGroup> AttributeGroups { get; set; }

  public DbSet<Particle> Particles { get; set; }

  public DbSet<ElementGroup> ElementGroups { get; set; }

  public Elements Elements
  {
    get
    {
      if (_Elements == null)
      {
        _Elements = new Elements(Particles);
      }

      return _Elements;
    }
  }
  private Elements? _Elements;

  public Dictionary<string, XsdFile> FilesDictionary { get; set; } = null!;

  public Dictionary<string, Namespace> NamespacesDictionary { get; set; } = null!;

  public string DbFilename { get; }

  public XmlSchemaDbContext(string dbFilename)
  {
    DbFilename = dbFilename;
    Database.EnsureCreated();
    SetupAccessDatabase();
  }


  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseJet(@$"Provider=Microsoft.ACE.OLEDB.16.0;Data Source={DbFilename};");
    //optionsBuilder.EnableSensitiveDataLogging(true);
    optionsBuilder.LogTo(message => Console.WriteLine(message));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<UsedNamespace>()
      .HasKey(e => new { SchemaFileId = e.FileId, e.NamespaceId });

    modelBuilder.Entity<UsedNamespace>()
      .HasOne(e => e.File)
      .WithMany(e => e.UsedNamespaces)
      .HasForeignKey(e => e.FileId);

    modelBuilder.Entity<UsedNamespace>()
      .HasOne(e => e.Namespace)
      .WithMany()
      .HasForeignKey(e => e.NamespaceId);

    modelBuilder.Entity<TypeDef>()
      .HasDiscriminator<bool>("IsComplex")
      .HasValue<SimpleType>(false)
      .HasValue<ComplexType>(true);

    modelBuilder.Entity<TypeDef>()
      .HasOne(item => item.OwnerNamespace)
      .WithMany(owner => owner.Types)
      .HasForeignKey(item => item.OwnerNamespaceId);

    modelBuilder.Entity<TypeDef>()
      .HasOne(e => e.BaseType)
      .WithMany()
      .HasForeignKey(e => e.BaseTypeId);

    modelBuilder.Entity<EnumValue>()
      .HasOne(item => item.OwnerType)
      .WithMany(owner => owner.EnumValues)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<Pattern>()
      .HasOne(item => item.OwnerType)
      .WithMany(owner => owner.Patterns)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<UnionMember>()
      .HasOne(item => item.OwnerType)
      .WithMany(owner => owner.UnionMembers)
      .HasForeignKey(item => item.OwnerTypeId);

    modelBuilder.Entity<UnionMember>()
      .HasOne(item => item.MemberType)
      .WithMany()
      .HasForeignKey(item => item.MemberTypeId);

    modelBuilder.Entity<ListItem>()
      .HasOne(item => item.MemberType)
      .WithMany()
      .HasForeignKey(item => item.MemberTypeId);

    modelBuilder.Entity<AttributeBase>()
      .HasOne(item => item.OwnerType)
      .WithMany(owner => owner.Attributes)
      .HasForeignKey(item => item.OwnerTypeId)
      .IsRequired(false);

    modelBuilder.Entity<AttributeBase>()
      .HasOne(item => item.OwnerNamespace)
      .WithMany(owner => owner.Attributes)
      .HasForeignKey(item => item.OwnerNamespaceId)
      .IsRequired(false);

    modelBuilder.Entity<AttributeBase>()
      .HasOne(item => item.OwnerGroup)
      .WithMany(owner => owner.Attributes)
      .HasForeignKey(item => item.OwnerGroupId)
      .IsRequired(false);

    modelBuilder.Entity<AttributeBase>()
      .HasDiscriminator<AttributeType>("Type")
      .HasValue<AttributeDef>(AttributeType.AttributeDef)
      .HasValue<AttributeRef>(AttributeType.AttributeRef)
      .HasValue<AttributeGroupRef>(AttributeType.AttributeGroupRef);

    modelBuilder.Entity<AttributeDef>()
      .HasOne(item => item.ValueType)
      .WithMany()
      .HasForeignKey(item => item.ValueTypeId);

    modelBuilder.Entity<AttributeRef>()
      .HasOne(item => item.RefAttribute)
      .WithMany()
      .HasForeignKey(item => item.RefAttributeId);

    modelBuilder.Entity<AttributeGroupRef>()
      .HasOne(item => item.RefGroup)
      .WithMany()
      .HasForeignKey(item => item.RefGroupId);

    modelBuilder.Entity<AttributeGroup>()
      .HasOne(item => item.OwnerNamespace)
      .WithMany(owner => owner.AttributeGroups)
      .HasForeignKey(item => item.OwnerNamespaceId)
      .IsRequired(false);

    modelBuilder.Entity<Particle>()
      .HasDiscriminator<ParticleType>("ParticleType")
      .HasValue<Any>(ParticleType.Any)
      .HasValue<Element>(ParticleType.Element)
      .HasValue<ElementGroupRef>(ParticleType.GroupRef)
      .HasValue<All>(ParticleType.All)
      .HasValue<Choice>(ParticleType.Choice)
      .HasValue<Sequence>(ParticleType.Sequence);

    modelBuilder.Entity<ElementGroupRef>()
      .HasOne(item => item.RefGroup)
      .WithMany()
      .HasForeignKey(item => item.RefGroupId);

    modelBuilder.Entity<ComplexType>()
      .HasOne(p => p.Particle)
      .WithOne(ct => ct.OwnerType)
      .HasForeignKey<ComplexType>(p => p.ParticleId)
      .IsRequired(false);

    modelBuilder.Entity<Particle>()
      .HasOne(p => p.OwnerParticle)
      .WithMany(g => g.Items)
      .HasForeignKey(p => p.OwnerParticleId)
      .IsRequired(false);

    modelBuilder.Entity<ElementGroup>()
      .HasOne(p => p.Particle)
      .WithOne(ct => ct.OwnerGroup)
      .HasForeignKey<ElementGroup>(p => p.ParticleId)
      .IsRequired(false);

    modelBuilder.Entity<Element>()
      .HasOne(e => e.RefElement)
      .WithMany()
      .HasForeignKey(e => e.RefElementId);

    modelBuilder.Entity<ElementGroup>()
      .HasOne(g => g.OwnerNamespace)
      .WithMany(g => g.ElementGroups)
      .HasForeignKey(p => p.OwnerNamespaceId);

    modelBuilder.Entity<Element>()
      .HasOne(g => g.OwnerNamespace)
      .WithMany(g => g.Elements)
      .HasForeignKey(p => p.OwnerNamespaceId);
  }

  internal void SetupAccessDatabase()
  {
    var accessApp = new Access.Application();
    Dao.Database database = null!;
    try
    {
      accessApp.OpenCurrentDatabase(DbFilename, false);
      database = accessApp.CurrentDb();
      Tools.SetQuery(database, "TypesList", "SELECT Types.Id, [Prefix] & \":\" & [Types].[Name] AS FullName\r\nFROM Namespaces INNER JOIN Types ON Namespaces.Id = Types.OwnerNamespaceId;");
      Tools.SetQuery(database, "AttributeGroupsList", "SELECT AttributeGroups.Id, [Prefix] & \":\" & [AttributeGroups].[Name] AS FullName\r\nFROM Namespaces INNER JOIN AttributeGroups ON Namespaces.Id = AttributeGroups.OwnerNamespaceId;");
      Tools.SetQuery(database, "NamespacesList", "SELECT Namespaces.Id, [Prefix] & \": \" & [Url] AS FullName\r\nFROM Namespaces;");
      Tools.SetQuery(database, "ElementGroupsList", "SELECT ElementGroups.Id, [Namespaces].[Prefix] & \":\" & [ElementGroups].[Name] AS FullName\r\nFROM Namespaces INNER JOIN ElementGroups ON Namespaces.Id = ElementGroups.OwnerNamespaceId;");

      //Tools.SetLookup(database, "Types", "OwnerNamespaceId", "NamespacesList");
      //Tools.SetLookup(database, "Types", "BaseTypeId", "TypesList");
      //Tools.SetLookup(database, "EnumValues", "OwnerTypeId", "TypesList");
      //Tools.SetLookup(database, "Patterns", "OwnerTypeId", "TypesList");
      //Tools.SetLookup(database, "UnionMembers", "OwnerTypeId", "TypesList");
      //Tools.SetLookup(database, "UnionMembers", "MemberTypeId", "TypesList");
      //Tools.SetLookup(database, "ListItems", "OwnerTypeId", "TypesList");
      //Tools.SetLookup(database, "ListItems", "MemberTypeId", "TypesList");

      Tools.CreateEnumLookupTable(database, "ContentTypes", typeof(ContentType));
      Tools.SetLookup(database, "Types", "ContentType", "ContentTypes");

      //Tools.SetLookup(database, "Attributes", "OwnerTypeId", "TypesList");
      //Tools.SetLookup(database, "Attributes", "OwnerGroupId", "AttributeGroupsList");
      //Tools.SetLookup(database, "Attributes", "OwnerNamespaceId", "NamespacesList");

      Tools.CreateEnumLookupTable(database, "AttributeTypes", typeof(AttributeType));
      Tools.SetLookup(database, "Attributes", "Type", "AttributeTypes");

      Tools.CreateEnumLookupTable(database, "ParticleTypes", typeof(ParticleType));
      Tools.SetLookup(database, "Particles", "ParticleType", "ParticleTypes");

      //Tools.SetLookup(database, "Particles", "OwnerNamespaceId", "NamespacesList");
      //Tools.SetLookup(database, "Particles", "OwnerTypeId", "TypesList");
      //Tools.SetLookup(database, "Particles", "OwnerGroupId", "ElementGroupsList");

      Tools.SetLookup(database, "ElementGroups", "OwnerNamespaceId", "NamespacesList");
    }
    catch (Exception ex)
    {
      Debug.WriteLine($"An error occurred: {ex.Message}");
    }
    finally
    {
      if (database != null)
      {
        accessApp.CloseCurrentDatabase();
      }
      accessApp.Quit(AcQuitOption.acQuitSaveAll);
      Marshal.ReleaseComObject(accessApp);
      accessApp = null!;
      // For good measure, force a garbage collection
      GC.Collect();
      GC.WaitForPendingFinalizers();
      Tools.KillMsAccess();
    }
 }


  public void LoadFiles()
  {
    FilesDictionary = Files.ToDictionary(file => file.FileName);
    NamespacesDictionary = Namespaces.ToDictionary(ns => ns.Url ?? "");

    Files.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (XsdFile file in args.NewItems!)
        {
          FilesDictionary.Add(file.FileName, file);
        }
      }
    };

    Namespaces.Local.CollectionChanged += (sender, args) =>

    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Namespace ns in args.NewItems!)
        {
          NamespacesDictionary.Add(ns.Url, ns);
        }
      }
    };
  }

  public void LoadNamespaces()
  {
    //DisplayMessageEnabled = true;
    foreach (var ns in Namespaces
               .Include(ns => ns.Types)
            )
    {
      ns.TypesDictionary = ns.Types.ToDictionary(type => type.Name, type => type);
    }
    Types.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (TypeDef type in args.NewItems!)
        {
          NamespacesDictionary[type.OwnerNamespace.Url].TypesDictionary.TryAdd(type.Name, type);
        }
      }
    };

    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.Patterns))
    {
      simpleType.PatternsDictionary = simpleType.Patterns.ToDictionary(pattern => pattern.Value);
      simpleType.HasPatterns = simpleType.PatternsDictionary.Count > 0;
    }
    Patterns.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Pattern pattern in args.NewItems!)
        {
          pattern.OwnerType.PatternsDictionary.TryAdd(pattern.Value, pattern);
        }
      }
    };

    foreach (var simpleType in Types.OfType<SimpleType>().Include(type => type.EnumValues))
    {
      simpleType.EnumValuesDictionary = simpleType.EnumValues.ToDictionary(enumValue => enumValue.Value);
      simpleType.IsEnum = simpleType.EnumValuesDictionary.Count > 0;
    }
    EnumValues.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (EnumValue enumValue in args.NewItems!)
        {
          enumValue.OwnerType.EnumValuesDictionary.TryAdd(enumValue.Value, enumValue);
        }
      }
    };

    foreach (var simpleType in Types.OfType<SimpleType>()
               .Include(type => type.UnionMembers)
               .ThenInclude(member => member.MemberType))
    {
      simpleType.UnionMembersDictionary = simpleType.UnionMembers
        .ToDictionary(unionMember => unionMember.MemberType.FullName);
      simpleType.IsUnion = simpleType.UnionMembersDictionary.Count > 0;
    }
    UnionMembers.Local.CollectionChanged += (sender, args) =>
       {
         if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
         {
           foreach (UnionMember unionMember in args.NewItems!)
           {
             try
             {
               unionMember.OwnerType.UnionMembersDictionary.TryAdd(unionMember.MemberType.FullName, unionMember);
             }
             catch (Exception e)
             {
               Console.WriteLine(e);
               throw;
             }
           }
         }
       };

    foreach (var simpleType in Types.OfType<SimpleType>()
               .Include(type => type.ListItems)
               .ThenInclude(item => item.MemberType))
    {
      simpleType.ListItemsDictionary = simpleType.ListItems
        .ToDictionary(ListItem => ListItem.MemberType.FullName);
      simpleType.IsList = simpleType.ListItemsDictionary.Count > 0;
    }
    ListItems.Local.CollectionChanged += (sender, args) =>
       {
         if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
         {
           foreach (ListItem listItem in args.NewItems!)
           {
             listItem.OwnerType.ListItemsDictionary.TryAdd(listItem.MemberType.FullName, listItem);
           }
         }
       };



    foreach (var ns in Namespaces
               .Include(ns => ns.Attributes))
    {
      ns.AttributesDictionary = ns.Attributes.ToDictionary(attribute => attribute.FullName, attribute => attribute);
    }

    foreach (var ns in Namespaces
               .Include(ns => ns.AttributeGroups))
    {
      ns.AttributeGroupsDictionary = ns.AttributeGroups.ToDictionary(attributeGroup => attributeGroup.FullName, attributeGroup => attributeGroup);
    }
    AttributeGroups.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (AttributeGroup group in args.NewItems!)
        {
          group.OwnerNamespace.AttributeGroupsDictionary.TryAdd(group.FullName, group);
        }
      }
    };

    foreach (var attribute in Attributes.OfType<AttributeDef>()
               .Include(attr => attr.ValueType))
    { }

    foreach (var attribute in Attributes.OfType<AttributeRef>()
               .Include(attr => attr.RefAttribute))
    {}

    foreach (var attribute in Attributes.OfType<AttributeGroupRef>()
               .Include(attr => attr.RefGroup))
    { }

    foreach (var attributeGroup in AttributeGroups
               .Include(group => group.Attributes))
    {
      attributeGroup.AttributesDictionary = attributeGroup.Attributes.ToDictionary(attribute => attribute.FullName, attribute => attribute);
    }

    foreach (var complexType in Types.OfType<ComplexType>()
               .Include(type => type.Attributes))
    {
      complexType.AttributesDictionary = complexType.Attributes
        .ToDictionary(attribute => attribute.FullName);
      complexType.HasAttributes = complexType.AttributesDictionary.Count > 0;
    }
    Attributes.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (AttributeBase attribute in args.NewItems!)
        {
          if (attribute.OwnerType != null)
          {
            attribute.OwnerType.AttributesDictionary.TryAdd(attribute.FullName, attribute);
          }
          else if (attribute.OwnerGroup != null)
          {
            attribute.OwnerGroup.AttributesDictionary.TryAdd(attribute.FullName, attribute);
          }
          else if (attribute.OwnerNamespace != null)
          {
            attribute.OwnerNamespace.AttributesDictionary.TryAdd(attribute.FullName, attribute);
          }
        }
      }
    };

    foreach (var ns in Namespaces
               .Include(ns => ns.Elements))
    {
      Debug.WriteLine($"Loading namespace: {ns.Url}");
      ns.ElementsDictionary = ns.Elements.ToDictionary(element => element.FullName, element => element);
    }
    Particles.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Element element in args.NewItems!.OfType<Element>())
        {
          if (element.OwnerNamespace != null)
            element.OwnerNamespace.ElementsDictionary.TryAdd(element.FullName, element);
        }
      }
    };

    foreach (var ns in Namespaces
           .Include(ns => ns.ElementGroups).ThenInclude(eg => eg.Particle))
    {
      ns.ElementGroupsDictionary = ns.ElementGroups.ToDictionary(group => group.FullName, group => group);
    }
    ElementGroups.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (ElementGroup group in args.NewItems!)
        {
          group.OwnerNamespace.ElementGroupsDictionary.TryAdd(group.FullName, group);
        }
      }
    };

    foreach (var ns in Namespaces
               .Include(ns => ns.Elements))
    {
      ns.ElementsDictionary = ns.Elements.ToDictionary(e => e.FullName, e => e);
    }
    Particles.Local.CollectionChanged += (sender, args) =>
    {
      if (args.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
      {
        foreach (Element element in args.NewItems!.OfType<Element>())
        {
          element.OwnerNamespace?.ElementsDictionary.TryAdd(element.FullName, element);
        }
      }
    };

    foreach (var complexType in Types.OfType<ComplexType>().Include(type => type.Particle))
    {
    };

    foreach (var particle in Particles.OfType<Element>())
    {
      if (particle.RefElementId != null && particle.RefElement == null)
      {
        particle.RefElement = Particles.OfType<Element>().First(e => e.Id == particle.RefElementId);
      }
      if (particle.RefTypeId != null && particle.RefType == null)
      {
        particle.RefType = Types.OfType<ComplexType>().FirstOrDefault(type => type.Id == particle.RefTypeId);
      }
    }

    foreach (var particle in Particles)
    {
      if (particle.OwnerTypeId != null)
      {
        particle.OwnerType ??= Types.OfType<ComplexType>().FirstOrDefault(type => type.Id == particle.OwnerTypeId);
        if (particle.OwnerType != null)
        {
          particle.OwnerType.ParticleId = particle.Id;
          particle.OwnerType.Particle = particle;
        }
      }
      if (particle.OwnerGroupId != null)
      {
        particle.OwnerGroup ??= ElementGroups.FirstOrDefault(type => type.Id == particle.OwnerGroupId);
        if (particle.OwnerGroup != null)
        {
          particle.OwnerGroup.ParticleId = particle.Id;
          particle.OwnerGroup.Particle = (ParticleGroup)particle;
        }
      }
      if (particle.OwnerParticleId != null)
      {
        particle.OwnerParticle ??= Particles.FirstOrDefault(type => type.Id == particle.OwnerParticleId) as ParticleGroup;
        if (particle.OwnerParticle != null)
        {
          particle.OwnerParticle.ItemsDictionary.TryAdd((int)particle.OrdNum!, particle);
        }
      }
      if (particle.OwnerNamespaceId != null)
      {
        particle.OwnerNamespace ??= Namespaces.FirstOrDefault(type => type.Id == particle.OwnerNamespaceId);
        if (particle.OwnerNamespace != null && particle is Element element)
        {
          particle.OwnerNamespace.ElementsDictionary.TryAdd(element.FullName, element);
        }
      }

    }

    SaveChanges();
  }
}
