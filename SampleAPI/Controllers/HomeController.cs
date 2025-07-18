using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Playwright;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;


namespace SampleAPI.Controllers;

[ApiController]
[Route("/")]

public class HomeController : Controller
{
    private readonly PlaywrightHolder _ph;
    public HomeController(PlaywrightHolder ph) => _ph = ph;

    public JsonResult Index()
    {
        return new JsonResult(new { success = false, message = "Login test app is currently running.." });
    }
    [HttpGet("/login")]
    public JsonResult Login()
    {
        var StateList = new List<string>
        {
            "Alaska",
            "Colorado",
            "Georgia",
            "Kansas",
            "Maine",
            "Pennsylvania",
            "Washington"

        };
        return new JsonResult(new { success = false, message = "Following State's login test is supported.", states = StateList });
    }

    [HttpPost("/login")]
    public async Task<JsonResult> VerifyLogin([FromBody] LoginModel model)
    {
        try
        {
            if (string.IsNullOrEmpty(model.state))
                return new JsonResult(new { success = false, message = "State parameter is required" });

            switch (model.state.ToLower())
            {
                // Alabama
                case "al":
                    //    return await VerifyAlabamaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Alaska
                case "ak":
                    return await VerifyAlaskaLogin(model);

                // Arizona
                case "az":
                    //    return await VerifyArizonaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Arkansas
                case "ar":
                    //    return await VerifyArkansasLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // California
                case "ca":
                    return await VerifyCaliforniaLogin(model);

                // Colorado
                case "co":
                    return await VerifyColoradoLoginPlaywright(model);

                // Connecticut
                case "ct":
                    //    return await VerifyConnecticutLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Delaware
                case "de":
                    //    return await VerifyDelawareLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Florida
                case "fl":
                    //    return await VerifyFloridaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Georgia
                case "ga":
                    return await VerifyGeorgiaLogin(model);

                // Hawaii
                case "hi":
                    //    return await VerifyHawaiiLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Idaho
                case "id":
                    //    return await VerifyIdahoLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Illinois
                case "il":
                    //    return await VerifyIllinoisLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Indiana
                case "in":
                    //    return await VerifyIndianaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Iowa
                case "ia":
                    //    return await VerifyIowaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Kansas
                case "ks":
                    return await VerifyKansasLogin(model);

                // Kentucky
                case "ky":
                    //    return await VerifyKentuckyLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Louisiana
                case "la":
                    return await VerifyLouisianaLogin(model);

                // Maine
                case "me":
                    return await VerifyMaineLogin(model);

                // Maryland
                case "md":
                    //    return await VerifyMarylandLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Massachusetts
                case "ma":
                    //    return await VerifyMassachusettsLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Michigan
                case "mi":
                    //    return await VerifyMichiganLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Minnesota
                case "mn":
                    //    return await VerifyMinnesotaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Mississippi
                case "ms":
                    //    return await VerifyMississippiLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Missouri
                case "mo":
                    //    return await VerifyMissouriLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Montana
                case "mt":
                    //    return await VerifyMontanaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Nebraska
                case "ne":
                    //    return await VerifyNebraskaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Nevada
                case "nv":
                    return await VerifyNevadaLogin(model);

                // New Hampshire
                case "nh":
                    //    return await VerifyNewHampshireLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // New Jersey
                case "nj":
                    //    return await VerifyNewJerseyLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // New Mexico
                case "nm":
                    //    return await VerifyNewMexicoLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // New York
                case "ny":
                    return await VerifyNewYorkLogin(model);

                // North Carolina
                case "nc":
                    //    return await VerifyNorthCarolinaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // North Dakota
                case "nd":
                    //    return await VerifyNorthDakotaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Ohio
                case "oh":
                    //    return await VerifyOhioLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Oklahoma
                case "ok":
                    //    return await VerifyOklahomaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Oregon
                case "or":
                    //    return await VerifyOregonLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Pennsylvania
                case "pa":
                    return await VerifyPennsylvaniaLoginPlaywright(model);

                // Rhode Island
                case "ri":
                    //    return await VerifyRhodeIslandLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // South Carolina
                case "sc":
                    //    return await VerifySouthCarolinaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // South Dakota
                case "sd":
                    return await VerifySouthDakotaLogin(model);
                //return new JsonResult(new { success = false, message = "Under Development...." });

                // Tennessee
                case "tn":
                    //    return await VerifyTennesseeLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Texas
                case "tx":
                    return await VerifyTexasLogin(model);
                //return new JsonResult(new { success = false, message = "Under Development...." });

                // Utah
                case "ut":
                    //    return await VerifyUtahLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Vermont
                case "vt":
                    //    return await VerifyVermontLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Virginia
                case "va":
                        return await VerifyVirginiaLogin(model);
                    //return new JsonResult(new { success = false, message = "Under Development...." });

                // Washington DC
                case "dc":
                    //    return await VerifyWashingtonDCLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Washington 
                case "wa":
                    return await VerifyWashingtonLogin(model);

                // West Virginia
                case "wv":
                    //    return await VerifyWestVirginiaLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Wisconsin
                case "wi":
                    //    return await VerifyWisconsinLogin(model);
                    return new JsonResult(new { success = false, message = "Under Development...." });

                // Wyoming
                case "wy":
                        return await VerifyWyomingLogin(model);
                    //return new JsonResult(new { success = false, message = "Under Development...." });

                default:
                    return new JsonResult(new { success = false, message = "Unsupported state" });
            }
        }
        catch (Exception ex)
        {
            return new JsonResult(new { success = false, message = ex.Message });
        }
    }

    private static bool IsChromeError(IPage p)
    {
        var u = p.Url ?? "";
        return u.Contains("chrome-error://", StringComparison.OrdinalIgnoreCase) ||
               u.Contains("chromewebdata", StringComparison.OrdinalIgnoreCase);
    }

    [HttpGet("/Louisianalogin")]
    public async Task<JsonResult> VerifyLouisianaLogin(LoginModel model, CancellationToken ct = default)
    {
        const string LoginUrl =
        "https://remotesellersfiling.la.gov/default.aspx" +
        "?page=%2fnotice.aspx";

        // One HttpClient per app (or DI singleton) – the handler keeps cookies.
        var handler = new HttpClientHandler { CookieContainer = new CookieContainer() };
        using var client = new HttpClient(handler) { Timeout = TimeSpan.FromSeconds(10) };
        client.DefaultRequestHeaders.UserAgent.ParseAdd(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
            "(KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36");

        /* ------------------------------------------------------------
         * 1.  GET the login page – harvest dynamic tokens & cookies
         * ---------------------------------------------------------- */
        var html = await client.GetStringAsync(LoginUrl, ct);

        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        // Helper to pull hidden‐field value by ID
        string Val(string id) => doc.GetElementbyId(id)?.Attributes["value"]?.Value ?? "";

        string viewState = Val("__VIEWSTATE");
        string viewGen = Val("__VIEWSTATEGENERATOR");
        string eventVal = Val("__EVENTVALIDATION");

        /* ------------------------------------------------------------
         * 2.  POST the filled form
         *     NB: field *names* include “ctl00$” exactly as in markup
         * ---------------------------------------------------------- */
        var form = new Dictionary<string, string>
        {
            ["__EVENTTARGET"] = "",
            ["__EVENTARGUMENT"] = "",
            ["__VIEWSTATE"] = viewState,
            ["__VIEWSTATEGENERATOR"] = viewGen,
            ["__EVENTVALIDATION"] = eventVal,
            ["UN"] = model.username,
            ["PW"] = model.password,
            ["cmdLogin2"] = "Sign In"
        };

        using var resp = await client.PostAsync(
            LoginUrl,
            new FormUrlEncodedContent(form),
            ct);

        // Follow redirect manually – faster than AutoRedirect=true when we just
        // need the target URL.  (KDOR returns 302 on success.)
        string finalUrl = resp.RequestMessage.RequestUri?.OriginalString ?? LoginUrl;

        bool success = finalUrl.Contains("remotesellersfiling.la.gov/notice.aspx",
                                         StringComparison.OrdinalIgnoreCase);

        /* ------------------------------------------------------------
         * 3.  Done – return JSON just like your original action
         * ---------------------------------------------------------- */
        return new JsonResult(new
        {
            success,
            message = success ? "Login successful." : "Invalid credentials."
        });
    }

    [HttpPost("/SouthDakotaLogin")]
    public async Task<JsonResult> VerifySouthDakotaLogin(LoginModel model)
    {
        const string LoginUrl = "https://apps.sd.gov/RV23EPath/Login.aspx";

        var browser = await _ph.GetBrowserAsync();
        var context = await browser.NewContextAsync();

        // Optional: block unnecessary resources
        await context.RouteAsync("**/*", route =>
        {
            var type = route.Request.ResourceType;
            if (type is "image" or "stylesheet" or "font")
                return route.AbortAsync();
            return route.ContinueAsync();
        });

        var page = await context.NewPageAsync();

        try
        {
            await page.GotoAsync(LoginUrl, new() { WaitUntil = WaitUntilState.NetworkIdle });

            // Fill form fields
            await page.FillAsync("input[name='ctl00$Content$txtUserName']", model.username);
            await page.FillAsync("input[name='ctl00$Content$txtPassword']", model.password);

            // Click the button
            await page.ClickAsync("input[name='ctl00$Content$btnContinue']");

            var loginResult = await Task.WhenAny(
                page.WaitForSelectorAsync("text=The username or password you have entered is incorrect", new() { Timeout = 5000 }),
                page.WaitForSelectorAsync("text=Main Menu", new() { Timeout = 5000 }),
                page.WaitForSelectorAsync("input[id='ctl00_Content_btnExit']", new() { Timeout = 5000 })
                );

            // Now re-check the DOM safely
            if (await page.IsVisibleAsync("text=The username or password you have entered is incorrect"))
            {
                return new JsonResult(new { success = false, message = "Invalid username or password" });
            }

            if (await page.IsVisibleAsync("input[id='ctl00_Content_btnExit']") || await page.IsVisibleAsync("text=Main Menu"))
            {
                return new JsonResult(new { success = true, message = "Login successful" });
            }
            return new JsonResult(new
            {
                success = false,
                message = "Unexpected response."
            });
        }
        catch (Exception ex)
        {
            return new JsonResult(new
            {
                success = false,
                message = "Error during login: " + ex.Message
            });
        }
        finally
        {
            await context.CloseAsync();
        }
    }
    [HttpPost("/TexasLogin")]
    public async Task<JsonResult> VerifyTexasLogin(LoginModel model)
    {
        try { 
        using (var httpClient = new HttpClient())
        {
            var jsonBody = new
            {
                userId = model.username,
                model.password
            };

            var jsonContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(jsonBody), System.Text.Encoding.UTF8, "application/json");

            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

            var response = await httpClient.PostAsync("https://security.app.cpa.state.tx.us/users/v2/authenticate", jsonContent);

            var responseContent = await response.Content.ReadAsStringAsync();


            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (responseContent.Contains("false"))
                {
                    return new JsonResult(new { success = false, message = "Login Successful." });
                }
            }

            if (response.StatusCode == System.Net.HttpStatusCode.UnprocessableContent)
            {
                if (responseContent.Contains("User ID or Password is invalid"))
                {
                    return new JsonResult(new { success = false, message = "Invalid Credentials.." });
                }
                
            }
        }
        return new JsonResult(new { success = false, message = "Unexpected response from server" });

        }
        catch (Exception ex)
        {
            return new JsonResult(new
            {
                success = false,
                message = "Error during login: " + ex.Message
            });
        }
    }

    [HttpGet("/Virginialogin")]
    public async Task<JsonResult> VerifyVirginiaLogin(LoginModel model)
    {
        if(string.IsNullOrEmpty(model.accountNumber))
            return new JsonResult(new { success = false, message = "Please provide Account Number with body as key of accountNumber." });

        var handler = new HttpClientHandler
        {
            AllowAutoRedirect = false, // We want to detect the 302 redirect
            UseCookies = true,
            CookieContainer = new CookieContainer()
        };

        using var httpClient = new HttpClient(handler);
        httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

        // Step 1: GET the login page to retrieve ViewState
        var loginPageResponse = await httpClient.GetAsync("https://www.business.tax.virginia.gov/VTOL/tax/Login.xhtml");
        var loginPageHtml = await loginPageResponse.Content.ReadAsStringAsync();

        // Extract javax.faces.ViewState
        var viewStateMatch = Regex.Match(loginPageHtml, @"name=""javax\.faces\.ViewState""[^>]*value=""([^""]+)""");
        if (!viewStateMatch.Success)
            return new JsonResult(new { success = false, message = "Could not retrieve ViewState." });


        string viewState = viewStateMatch.Groups[1].Value;

        // Step 2: Submit the login form
        var formContent = new FormUrlEncodedContent(new[]
        {
        new KeyValuePair<string, string>("loginForm", "loginForm"),
        new KeyValuePair<string, string>("loginForm:customerType", "T"),
        new KeyValuePair<string, string>("loginForm:customerNumber", model.accountNumber),
        new KeyValuePair<string, string>("loginForm:userName", model.username),
        new KeyValuePair<string, string>("loginForm:password", model.password),
        new KeyValuePair<string, string>("loginForm:loginButton", "Log In"),
        new KeyValuePair<string, string>("javax.faces.ViewState", viewState),
    });

        var postResponse = await httpClient.PostAsync("https://www.business.tax.virginia.gov/VTOL/tax/Login.xhtml", formContent);
        var postContent = await postResponse.Content.ReadAsStringAsync();

        if (postResponse.StatusCode == HttpStatusCode.OK)
        {
            // Login failed, look for the error message
            if (postContent.Contains("The combination of Account Number,User ID and Password does not match our records"))
            {
                return new JsonResult(new { success = false, message = "Invalid username, password, or account number." });
            }

            return new JsonResult(new { success = false, message = "Invalid username, password, or account number." });


        }
        else if (postResponse.StatusCode == HttpStatusCode.Found)
        {
            // Login successful, follow redirect
            if (postResponse.Headers.Location != null)
            {
                var nextPageUrl = new Uri(postResponse.Headers.Location.OriginalString);
                var homePageResponse = await httpClient.GetAsync(nextPageUrl);
                var homeHtml = await homePageResponse.Content.ReadAsStringAsync();

                // Verify the customer number appears on the page
                if (homeHtml.Contains("mojarra.jsfcljs") && homeHtml.Contains("'logout':'true'"))
                {
                    return new JsonResult(new { success = true, message = "Login successful." });
                }

                return new JsonResult(new { success = true, message = "Login successful." });
            }

           
        }
        return new JsonResult(new { success = false, message = "Unexpected response status." });
    }
    [HttpGet("/NewYorklogin")]
    public async Task<JsonResult> VerifyNewYorkLogin(LoginModel model)
    {
        const string LoginUrl =
            "https://my.ny.gov/LoginV4/login.xhtml?APP=nyappdtf";

        const int MaxGotoRetries = 2;          // 1 initial + 2 retries = 3 attempts
        const bool UseFirefox = true;      // flip to true if Chromium still fails

        try
        {
            /* ── 1.  Get hot browser instance ───────────────────────────── */
            var browser = await _ph.GetBrowserAsync(UseFirefox ? "firefox" : "chromium");

            var context = await browser.NewContextAsync(new BrowserNewContextOptions
            {
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                            "(KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36"
            });

            await context.AddInitScriptAsync(
                "Object.defineProperty(navigator,'webdriver',{get:()=>undefined});");

            await context.RouteAsync("**/*", r =>
            {
                var t = r.Request.ResourceType;
                if (t is "image" or "stylesheet" or "font") r.AbortAsync();
                else r.ContinueAsync();
            });

            var page = await context.NewPageAsync();

            /* ── 2.  Robust navigation with retry ───────────────────────── */
            for (int attempt = 1; attempt <= MaxGotoRetries + 1; attempt++)
            {
                try
                {
                    await page.GotoAsync(LoginUrl, new() { Timeout = 20000 });
                    if (!IsChromeError(page)) break;     // success
                    throw new PlaywrightException("chrome error page");   // force retry
                }
                catch (PlaywrightException ex) when (attempt <= MaxGotoRetries)
                {
                    await Task.Delay(1500 * attempt); // back‑off
                    continue;                         // retry
                }
            }

            /* ── 3.  Fill & submit ──────────────────────────────────────── */

            await page.FillAsync("#loginform\\:username", model.username);
            await page.FillAsync("#loginform\\:password", model.password);

            await page.ClickAsync("button[id='loginform:signinButton']");

            // Wait up to 30 seconds for the POST request to be made
            var requestTask = page.WaitForRequestAsync(req =>
                req.Url.Contains("/LoginV4/login.xhtml", StringComparison.OrdinalIgnoreCase) &&
                req.Method.Equals("POST", StringComparison.OrdinalIgnoreCase)
            );

            var completed = await Task.WhenAny(requestTask, Task.Delay(30000));

            if (completed != requestTask)
            {
                return new JsonResult(new { success = false, message = "Timed out waiting for login request." });
            }

            var request = await requestTask;
            var response = await request.ResponseAsync();
            var statusCode = response?.Status ?? 0;

            return statusCode switch
            {
                302 => new JsonResult(new { success = true, message = "Login successful." }),
                200 => new JsonResult(new { success = false, message = "Invalid username or password." }),
                _ => new JsonResult(new { success = false, message = $"Unexpected status code: {statusCode}" })
            };
        }
        catch (Exception ex)
        {
            return Json(false, "Error: " + ex.Message);
        }
    }
    JsonResult Json(bool ok, string msg) => new(new { success = ok, message = msg });


    [HttpGet("/Nevadalogin")]
    public async Task<JsonResult> VerifyNevadaLogin(LoginModel model)
    {
        try
        {
            using var handler = new HttpClientHandler
            {
                AllowAutoRedirect = false // so we can detect 302 manually
            };

            using var client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://www.nevadatax.nv.gov/");
            client.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                "(KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36");

            // 1. Load login page to get CSRF token
            var loginPage = await client.GetStringAsync("/");
            var token = Regex.Match(loginPage, @"name=""__RequestVerificationToken""\s+type=""hidden""\s+value=""([^""]+)""")
                             .Groups[1].Value;

            if (string.IsNullOrEmpty(token))
            {
                return new JsonResult(new { success = false, message = "CSRF token not found." });
            }

            // 2. Prepare login form
            var form = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "__RequestVerificationToken", token },
            { "UserName", model.username },
            { "Password", model.password }
        });

            // 3. Post login request
            var resp = await client.PostAsync("/", form);

            if ((int)resp.StatusCode == 302)
            {
                // Login successful, check destination
                var location = resp.Headers.Location?.ToString();
                if (location != null && location.Contains("dashboard", StringComparison.OrdinalIgnoreCase))
                {
                    return new JsonResult(new { success = true, message = "Login successful." });
                }

                return new JsonResult(new
                {
                    success = true,
                    message = $"Login redirected to: {location ?? "unknown"}"
                });
            }
            else if ((int)resp.StatusCode == 200)
            {
                var content = await resp.Content.ReadAsStringAsync();
                if (content.Contains("Invalid username or password", StringComparison.OrdinalIgnoreCase))
                {
                    return new JsonResult(new { success = false, message = "Invalid username or password" });
                }

                return new JsonResult(new
                {
                    success = false,
                    message = "Login failed for unknown reason. Page content doesn't contain expected error."
                });
            }

            return new JsonResult(new
            {
                success = false,
                message = $"Unexpected response: HTTP {(int)resp.StatusCode}"
            });
        }
        catch (Exception ex)
        {
            return new JsonResult(new { success = false, message = "Error: " + ex.Message });
        }
    }

    [HttpGet("/Kansaslogin")]
    public async Task<JsonResult> VerifyKansasLogin(LoginModel model, CancellationToken ct = default)
    {
        const string LoginUrl =
        "https://www.kdor.ks.gov/Apps/kcsc/login.aspx" +
        "?ReturnUrl=%2fapps%2fkcsc%2fsecure%2fdefault.aspx";

        // One HttpClient per app (or DI singleton) – the handler keeps cookies.
        var handler = new HttpClientHandler { CookieContainer = new CookieContainer() };
        using var client = new HttpClient(handler) { Timeout = TimeSpan.FromSeconds(10) };
        client.DefaultRequestHeaders.UserAgent.ParseAdd(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
            "(KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36");

        /* ------------------------------------------------------------
         * 1.  GET the login page – harvest dynamic tokens & cookies
         * ---------------------------------------------------------- */
        var html = await client.GetStringAsync(LoginUrl, ct);

        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        // Helper to pull hidden‐field value by ID
        string Val(string id) => doc.GetElementbyId(id)?.Attributes["value"]?.Value ?? "";

        string viewState = Val("__VIEWSTATE");
        string viewGen = Val("__VIEWSTATEGENERATOR");
        string eventVal = Val("__EVENTVALIDATION");

        /* ------------------------------------------------------------
         * 2.  POST the filled form
         *     NB: field *names* include “ctl00$” exactly as in markup
         * ---------------------------------------------------------- */
        var form = new Dictionary<string, string>
        {
            ["__EVENTTARGET"] = "",
            ["__EVENTARGUMENT"] = "",
            ["__VIEWSTATE"] = viewState,
            ["__VIEWSTATEGENERATOR"] = viewGen,
            ["__EVENTVALIDATION"] = eventVal,
            ["ctl00$cphBody$txtUserName"] = model.username,
            ["ctl00$cphBody$txtPassword"] = model.password,
            ["ctl00$cphBody$cmdSignIn"] = "Sign In"
        };

        using var resp = await client.PostAsync(
            LoginUrl,
            new FormUrlEncodedContent(form),
            ct);

        // Follow redirect manually – faster than AutoRedirect=true when we just
        // need the target URL.  (KDOR returns 302 on success.)
        string finalUrl = resp.RequestMessage.RequestUri?.OriginalString ?? LoginUrl;

        bool success = finalUrl.Contains("/kcsc/secure/default.aspx",
                                         StringComparison.OrdinalIgnoreCase);

        /* ------------------------------------------------------------
         * 3.  Done – return JSON just like your original action
         * ---------------------------------------------------------- */
        return new JsonResult(new
        {
            success,
            message = success ? "Login successful." : "Invalid credentials."
        });
    }

    [HttpGet("/Wyominglogin")]
    public async Task<JsonResult> VerifyWyomingLogin(LoginModel model)
    {
        var browser = await _ph.GetBrowserAsync();

        var context = await browser.NewContextAsync(new BrowserNewContextOptions
        {
            UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                        "(KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36"
        });

        var page = await context.NewPageAsync();

        try
        {
            await page.GotoAsync("https://excise-wyifs.wy.gov/default.aspx?ReturnUrl=%2fSalesUse%2fMain.aspx", new() { WaitUntil = WaitUntilState.NetworkIdle });

            await page.ClickAsync("span[class='close']");
            // Fill form fields (all IDs/names as per original HTML)
            await page.FillAsync("input[name='ctl00$CenterContent$txtUserName']", model.username);
            await page.FillAsync("input[name='ctl00$CenterContent$txtPassword']", model.password);
            await page.FillAsync("input[name='ctl00$CenterContent$txtPin']", model.pin);

            await page.ClickAsync("input[name='ctl00$CenterContent$btnSignIn']");
            await page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Check for login failure message span
            var errorVisible = await page.Locator("#ctl00_CenterContent_lblErrorMessage").IsVisibleAsync();

            if (errorVisible)
            {
                return new JsonResult(new
                {
                    success = false,
                    message = "Invalid credentials. Login failed."
                });
            }

            // Look for the 'Log Out' anchor with class 'biggertext'
            var logoutVisible = await page.Locator("a.biggertext", new() { HasTextString = "Log Out" }).IsVisibleAsync();

            if (logoutVisible)
            {
                return new JsonResult(new
                {
                    success = true,
                    message = "Login successful."
                });
            }

            // Fallback case: page did not show expected success or error indicators
            return new JsonResult(new
            {
                success = false,
                message = "Unknown login result. 'Log Out' link not found."
            });
        }
        catch (Exception ex)
        {
            return new JsonResult(new
            {
                success = false,
                message = $"Exception occurred: {ex.Message}"
            });
        }
    }



    [HttpGet("/Washingtonlogin")]
    public async Task<JsonResult> VerifyWashingtonLogin(LoginModel model)
    {
        var browser = await _ph.GetBrowserAsync();

        var context = await browser.NewContextAsync(new()
        {
            UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                        "(KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36"
        });

        var page = await context.NewPageAsync();

        try
        {
            await page.GotoAsync("https://secure.dor.wa.gov/home/Login", new() { WaitUntil = WaitUntilState.NetworkIdle });

            await page.FillAsync("#username", model.username);
            await page.FillAsync("#password", model.password);

            await page.ClickAsync("#signin");

            // Wait for navigation after clicking sign in
            await page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            // Capture final URL after login attempt
            var finalUrl = page.Url;

            if (finalUrl.Contains("rfs=BadLogin", StringComparison.OrdinalIgnoreCase))
            {
                return new JsonResult(new
                {
                    success = false,
                    message = "Invalid credentials. Login failed."
                });
            }

            if (finalUrl.Contains("rfs=ActiveSession", StringComparison.OrdinalIgnoreCase) ||
                finalUrl.Contains("mga/sps/authsvc?TransactionId=", StringComparison.OrdinalIgnoreCase) ||
                finalUrl.Contains("/home/mydor", StringComparison.OrdinalIgnoreCase))
            {
                return new JsonResult(new
                {
                    success = true,
                    message = "Login successful."
                });
            }

            // Catch unknown flow
            return new JsonResult(new
            {
                success = false,
                message = $"Unexpected response. URL: {finalUrl}"
            });
        }
        catch (Exception ex)
        {
            return new JsonResult(new
            {
                success = false,
                message = $"Exception occurred: {ex.Message}"
            });
        }
    }


    [HttpGet("/Pennsylvanialogin")]
    public async Task<JsonResult> VerifyPennsylvaniaLoginPlaywright(LoginModel model)
    {
        return await LoginByBrowserAutomate(model, "https://mypath.pa.gov/_/");
    }

    [HttpGet("/Coloradologin")]
    public async Task<JsonResult> VerifyColoradoLoginPlaywright(LoginModel model)
    {
        return await LoginByBrowserAutomate(model, "https://www.colorado.gov/revenueonline/_/");
    }
    [HttpGet("/Californialogin")]
    public async Task<JsonResult> VerifyCaliforniaLogin(LoginModel model)
    {
        return await LoginByBrowserAutomate(model, "https://onlineservices.cdtfa.ca.gov/_/");
    }
    [HttpGet("/Georgialogin")]
    public async Task<JsonResult> VerifyGeorgiaLogin(LoginModel model)
    {
        return await LoginByBrowserAutomate(model, "https://gtc.dor.ga.gov/_/");
    }
    [HttpGet("/Mainelogin")]
    public async Task<JsonResult> VerifyMaineLogin(LoginModel model)
    {
        return await LoginByBrowserAutomate(model, "https://revenue.maine.gov/_/");
    }

    private async Task<JsonResult> VerifyAlaskaLogin(LoginModel model)
    {
        using (var httpClient = new HttpClient())
        {
            // Prepare the form data
            var formContent = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("login_username", model.username),
            new KeyValuePair<string, string>("login_password", model.password),
            new KeyValuePair<string, string>("login_return_to", ""),
            new KeyValuePair<string, string>("submitbutton", "Log In")
        });

            // Disable automatic redirect following so we can check the status code
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
            var response = await httpClient.PostAsync("https://arsstc.munirevs.com/log-in/", formContent);

            // If status is 302, login was successful
            if (response.StatusCode == System.Net.HttpStatusCode.Found)
            {
                return new JsonResult(new { success = true });
            }

            // If status is 200, check for error message in response
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                if (responseContent.Contains("Invalid Credentials.."))
                {
                    return new JsonResult(new { success = false, message = "Invalid Credentials.." });
                }
                else
                {
                    if (responseContent.Contains("Log Out"))
                    {
                        return new JsonResult(new { success = true, message = "Yes, It's Alaska's valid credentials" });
                    }
                }
            }

            return new JsonResult(new { success = false, message = "Unexpected response from server" });
        }
    }



    private async Task<JsonResult> LoginByBrowserAutomate(LoginModel model, string LoginUrl)
    {
        var browser = await _ph.GetBrowserAsync();

        var context = await browser.NewContextAsync();

        await context.RouteAsync("**/*", route =>
        {
            var t = route.Request.ResourceType;
            if (t is "image" or "stylesheet" or "font")
                return route.AbortAsync();
            return route.ContinueAsync();
        });


        var page = await context.NewPageAsync();

        try
        {
            await page.GotoAsync(LoginUrl);

            await page.FillAsync("input[name='Dd-5']", model.username);
            await page.FillAsync("input[name='Dd-6']", model.password);

            // simulate clicking or triggering the submit
            await page.ClickAsync("#Dd-7");



            // Wait for the next response or check some indicator
            // Wait for either success or error indicator
            var loginResult = await Task.WhenAny(
                page.WaitForSelectorAsync("text=Invalid user name", new() { Timeout = 5000 }),
                page.WaitForSelectorAsync("text=Invalid Username", new() { Timeout = 5000 }),
                page.WaitForSelectorAsync("text=Verify Security Code", new() { Timeout = 5000 }),
                page.WaitForSelectorAsync("text=Logout", new() { Timeout = 5000 }) // or any valid post-login text
            );

            // Now re-check the DOM safely
            if (await page.IsVisibleAsync("text=Invalid user name") || await page.IsVisibleAsync("text=Invalid Username"))
            {
                return new JsonResult(new { success = false, message = "Invalid username or password" });
            }

            if (await page.IsVisibleAsync("text=Verify Security Code"))
            {
                return new JsonResult(new
                {
                    success = true,
                    message = "Login successful but requires security code verification"
                });
            }
            if (await page.IsVisibleAsync("text=Logout"))
            {
                return new JsonResult(new { success = true, message = "Login successful" });
            }


            return new JsonResult(new { success = false, message = "There is an issue." });

        }
        catch (Exception ex)
        {
            return new JsonResult(new { success = false, message = ex.Message });
        }
    }
}


public class LoginModel
{
    public string username { get; set; }
    public string accountNumber { get; set; } = string.Empty;
    public string pin { get; set; } = string.Empty;
    public string password { get; set; }
    public string state { get; set; }
}
