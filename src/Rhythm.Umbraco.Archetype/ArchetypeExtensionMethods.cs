namespace Rhythm.Umbraco.Archetype
{

    // Namespaces.
    using global::Archetype.Models;
    using System.Linq;
    using Fieldsets = System.Collections.Generic.IEnumerable<global::Archetype.Models.ArchetypeFieldsetModel>;

    /// <summary>
    /// Extension methods for Archetype.
    /// </summary>
    public static class ArchetypeExtensionMethods
    {

        #region Methods

        /// <summary>
        /// Gets only the enabled fieldsets.
        /// </summary>
        /// <param name="model">
        /// The Archetype model.
        /// </param>
        /// <returns>
        /// The enabled fieldsets.
        /// </returns>
        public static Fieldsets EnabledFieldsets(this ArchetypeModel model)
        {
            return model == null
                ? Enumerable.Empty<ArchetypeFieldsetModel>()
                : model.Fieldsets.Where(x => !x.Disabled);
        }

        /// <summary>
        /// Returns the first enabled fieldset from the specified Archetype model.
        /// </summary>
        /// <param name="model">
        /// The Archetype model.
        /// </param>
        /// <returns>
        /// The first enabled fieldset.
        /// </returns>
        public static ArchetypeFieldsetModel FirstEnabledFieldset(this ArchetypeModel model)
        {
            return model.EnabledFieldsets().FirstOrDefault();
        }

        #endregion

    }

}