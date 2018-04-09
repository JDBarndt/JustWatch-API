using JustWatchApi.Models;
using JustWatchApi.Models.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace JustWatchApi.Tests
{
    [TestClass]
    public class JustWatchClientTests
    {
        private readonly JustWatchClient client = new JustWatchClient();

        [TestMethod]
        public void GetAgeCertifications_NoFilters_HasResults()
        {
            var response = client.GetAgeCertifications(new GetAgeCertificationsRequest());

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
        }

        [TestMethod]
        public async Task GetAgeCertificationsAsync_NoFilters_HasResults()
        {
            var response = await client.GetAgeCertificationsAsync(new GetAgeCertificationsRequest());

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
        }

        [TestMethod]
        public void GetAgeCertifications_UnitedStates_HasOnlyUSResults()
        {
            var request = new GetAgeCertificationsRequest() { Country = Country.UnitedStates };
            var response = client.GetAgeCertifications(request);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
            Assert.AreEqual(0, response.Where(x => x.Country != "US").Count());
        }

        [TestMethod]
        public async Task GetAgeCertificationsAsync_UnitedStates_HasOnlyUSResults()
        {
            var request = new GetAgeCertificationsRequest() { Country = Country.UnitedStates };
            var response = await client.GetAgeCertificationsAsync(request);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
            Assert.AreEqual(0, response.Where(x => x.Country != "US").Count());
        }

        [TestMethod]
        public void GetAgeCertifications_Movie_HasOnlyMovieResults()
        {
            var request = new GetAgeCertificationsRequest() { ContentType = ContentType.Movie };
            var response = client.GetAgeCertifications(request);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
            Assert.AreEqual(0, response.Where(x => x.ObjectType != "movie").Count());
        }

        [TestMethod]
        public async Task GetAgeCertificationsAsync_Movie_HasOnlyMovieResults()
        {
            var request = new GetAgeCertificationsRequest() { ContentType = ContentType.Movie };
            var response = await client.GetAgeCertificationsAsync(request);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
            Assert.AreEqual(0, response.Where(x => x.ObjectType != "movie").Count());
        }

        [TestMethod]
        public void GetGenres_UnitedStates_HasResults()
        {
            var response = client.GetGenres(new GetGenresRequest(Country.UnitedStates));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
        }

        [TestMethod]
        public async Task GetGenresAsync_UnitedStates_HasResults()
        {
            var response = await client.GetGenresAsync(new GetGenresRequest(Country.UnitedStates));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
        }

        [TestMethod]
        public void GetLocales_NoFilters_HasResults()
        {
            var response = client.GetLocales(new GetLocalesRequest());

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
        }

        [TestMethod]
        public async Task GetLocalesAsync_NoFilters_HasResults()
        {
            var response = await client.GetLocalesAsync(new GetLocalesRequest());

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
        }

        [TestMethod]
        public void GetLocales_UnitedStates_HasOnlyUSResult()
        {
            var request = new GetLocalesRequest() { Country = Country.UnitedStates };
            var response = client.GetLocales(request);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
            Assert.AreEqual(0, response.Where(x => x.FullLocale != "en_US").Count());
        }

        [TestMethod]
        public async Task GetLocalesAsync_UnitedStates_HasOnlyUSResult()
        {
            var request = new GetLocalesRequest() { Country = Country.UnitedStates };
            var response = await client.GetLocalesAsync(request);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
            Assert.AreEqual(0, response.Where(x => x.FullLocale != "en_US").Count());
        }

        [TestMethod]
        public void GetMovie_UnitedStates_HasResult()
        {
            var response = client.GetMovie(new GetMovieRequest(Country.UnitedStates, 122337));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Id == 122337);
        }

        [TestMethod]
        public async Task GetMovieAsync_UnitedStates_HasResult()
        {
            var response = await client.GetMovieAsync(new GetMovieRequest(Country.UnitedStates, 122337));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Id == 122337);
        }

        [TestMethod]
        public void GetPopular_UnitedStates_HasResults()
        {
            var response = client.GetPopular(new GetPopularRequest(Country.UnitedStates));

            Assert.IsNotNull(response?.Items);
            Assert.IsTrue(response.Items.Length > 0);
        }

        [TestMethod]
        public async Task GetPopularAsync_UnitedStates_HasResults()
        {
            var response = await client.GetPopularAsync(new GetPopularRequest(Country.UnitedStates));

            Assert.IsNotNull(response?.Items);
            Assert.IsTrue(response.Items.Length > 0);
        }

        [TestMethod]
        public void GetProviders_UnitedStates_HasResults()
        {
            var response = client.GetProviders(new GetProvidersRequest(Country.UnitedStates));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
        }

        [TestMethod]
        public async Task GetProvidersAsync_UnitedStates_HasResults()
        {
            var response = await client.GetProvidersAsync(new GetProvidersRequest(Country.UnitedStates));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count > 0);
        }

        [TestMethod]
        public void GetSeason_UnitedStates_HasResult()
        {
            var response = client.GetSeason(new GetSeasonRequest(Country.UnitedStates, 9));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Id == 9);
        }

        [TestMethod]
        public async Task GetSeasonAsync_UnitedStates_HasResult()
        {
            var response = await client.GetSeasonAsync(new GetSeasonRequest(Country.UnitedStates, 9));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Id == 9);
        }

        [TestMethod]
        public void GetShow_UnitedStates_HasResult()
        {
            var response = client.GetShow(new GetShowRequest(Country.UnitedStates, 12));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Id == 12);
        }

        [TestMethod]
        public async Task GetShowAsync_UnitedStates_HasResult()
        {
            var response = await client.GetShowAsync(new GetShowRequest(Country.UnitedStates, 12));

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Id == 12);
        }

        [TestMethod]
        public void GetTitles_UnitedStatesMovieAndShow_HasResults()
        {
            var response = client.GetTitles(new GetTitlesRequest(Country.UnitedStates)
            {
                Titles = new Models.Title.TitlesRequest()
                {
                    Movie = new int[] {122337},
                    Show = new int[] {12}
                }
            });

            Assert.IsNotNull(response?.Titles?.Movie?.FirstOrDefault());
            Assert.IsNotNull(response?.Titles?.Show?.FirstOrDefault());
            Assert.IsTrue(response.Titles.Movie.First().Id == 122337);
            Assert.IsTrue(response.Titles.Show.First().Id == 12);
        }

        [TestMethod]
        public async Task GetTitlesAsync_UnitedStatesMovieAndShow_HasResults()
        {
            var response = await client.GetTitlesAsync(new GetTitlesRequest(Country.UnitedStates)
            {
                Titles = new Models.Title.TitlesRequest()
                {
                    Movie = new int[] { 122337 },
                    Show = new int[] { 12 }
                }
            });

            Assert.IsNotNull(response?.Titles?.Movie?.FirstOrDefault());
            Assert.IsNotNull(response?.Titles?.Show?.FirstOrDefault());
            Assert.IsTrue(response.Titles.Movie.First().Id == 122337);
            Assert.IsTrue(response.Titles.Show.First().Id == 12);
        }
    }
}
