using CodeFramework.Core.Data;
using SQLite;

namespace CodeHub.Core.Data
{
    public class GitHubAccount : Account
    {
        /// <summary>
        /// Gets or sets the OAuth string
        /// </summary>
        public string OAuth { get; set; }

        /// <summary>
		/// Gets or sets the domain (API)
        /// </summary>
        /// <value>The domain.</value>
        public string Domain { get; set; }

		/// <summary>
		/// Gets or sets the web domain. Sort of like the API domain with the API paths
		/// </summary>
		/// <value>The web domain.</value>
		public string WebDomain { get; set; }

        /// <summary>
        /// Gets or sets whether orgs should be listed in the menu controller under 'events'
        /// </summary>
        public bool ShowOrganizationsInEvents { get; set; }

        /// <summary>
        /// Gets or sets whether teams & groups should be expanded in the menu controller to their actual contents
        /// </summary>
        public bool ExpandOrganizations { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Account"/> hides the repository
        /// description in list.
        /// </summary>
        /// <value><c>true</c> if hide repository description in list; otherwise, <c>false</c>.</value>
        public bool ShowRepositoryDescriptionInList { get; set; }

        /// <summary>
        /// A transient record of the user's name
        /// </summary>
        [Ignore]
        public string FullName { get; set; }

        /// <summary>
        /// A list of the current notifications
        /// </summary>
        /// <value>The notifications.</value>
        [Ignore]
        public int? Notifications { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Account"/> class.
		/// </summary>
		public GitHubAccount()
		{
			//Set some default values
			DontRemember = false;
            ShowOrganizationsInEvents = true;
            ExpandOrganizations = true;
            ShowRepositoryDescriptionInList = true;
		}
    }
}

