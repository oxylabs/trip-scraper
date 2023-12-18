package main

import (
	"bytes"
	"encoding/json"
	"fmt"
	"io/ioutil"
	"net/http"
)

func main() {
	const Username = "YOUR_USERNAME"
	const Password = "YOUR_PASSWORD"

	payload := map[string]string{
		"source": "universal",
		"url": "https://www.trip.com/flights?locale=en-xx&allianceid=742331&sid=2506234&ppcid=adid-660427218467_akid-kwd-11635721_adgid-144762786930&utm_source=google&utm_medium=cpc&utm_campaign=sitelink&utm_extensiontype=sitelink&utm_extension=flight&gad_source=1&gclid=cj0kcqia7oqrbhd9arisak3uxh0t8thl3l86ic0h1fo1wind3utjhjhrafxiu3yeyfc3trwbfv4pz0kaahvlealw_wcb",
	}

	jsonValue, _ := json.Marshal(payload)

	client := &http.Client{}
	request, _ := http.NewRequest("POST",
		"https://realtime.oxylabs.io/v1/queries",
		bytes.NewBuffer(jsonValue),
	)

	request.SetBasicAuth(Username, Password)
	response, _ := client.Do(request)

	responseText, _ := ioutil.ReadAll(response.Body)
	fmt.Println(string(responseText))
}