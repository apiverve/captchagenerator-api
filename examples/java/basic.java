import com.apiverve.captchagenerator.CaptchaGeneratorAPIClient;
import com.apiverve.captchagenerator.APIResponse;
import com.apiverve.captchagenerator.APIException;
import org.json.JSONObject;

import java.util.HashMap;
import java.util.Map;

public class BasicExample {
    public static void main(String[] args) {
        // Initialize the API client with your API key
        CaptchaGeneratorAPIClient client = new CaptchaGeneratorAPIClient("YOUR_API_KEY_HERE");

        try {
            // Query parameters
            Map&lt;String, Object&gt; parameters &#x3D; new HashMap&lt;&gt;();
        parameters.put(&quot;type&quot;, &quot;math&quot;);
        parameters.put(&quot;length&quot;, 6);
        parameters.put(&quot;charset&quot;, &quot;alphanumeric&quot;);
        parameters.put(&quot;unambiguous&quot;, true);
        parameters.put(&quot;difficulty&quot;, &quot;hard&quot;);
        parameters.put(&quot;width&quot;, 240);
        parameters.put(&quot;height&quot;, 80);
        parameters.put(&quot;format&quot;, &quot;png&quot;);
        parameters.put(&quot;audio&quot;, true);
        parameters.put(&quot;audioNoise&quot;, &quot;low&quot;);
        parameters.put(&quot;inline&quot;, true);

            // Execute the API request
            APIResponse response = client.execute(parameters);

            // Check if the request was successful
            if (response.isSuccess()) {
                System.out.println("✅ Success!");

                // Get the response data
                JSONObject data = response.getData();
                if (data != null) {
                    System.out.println("Response data:");
                    System.out.println(data.toString(2)); // Pretty print with 2-space indent
                }

                // Or get specific fields from the data
                // String value = data.optString("fieldName");

            } else {
                // Handle API errors
                System.err.println("❌ API Error: " + response.getError());
                System.err.println("Status: " + response.getStatus());
                System.err.println("Code: " + response.getCode());
            }

        } catch (APIException e) {
            // Handle exceptions
            System.err.println("❌ Error: " + e.getMessage());

            // Handle specific error types
            if (e.isAuthenticationError()) {
                System.err.println("Invalid API key. Get your key at: https://apiverve.com");
            } else if (e.isRateLimitError()) {
                System.err.println("Rate limit exceeded. Please try again later.");
            } else if (e.isServerError()) {
                System.err.println("Server error (5xx). Please try again later.");
            } else if (e.isClientError()) {
                System.err.println("Client error (4xx). Check your request parameters.");
            }

            // Get HTTP status code if available
            if (e.getStatusCode() > 0) {
                System.err.println("HTTP Status Code: " + e.getStatusCode());
            }
        }
    }
}
