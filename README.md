<p><a href="https://tomoya-a1sss.azurewebsites.net">This website</a> stores information about questions.</p>
<ol>
<li><a href="https://server-side-scripting-assignment-2-part-3.azurewebsites.net/api/questions">This API</a> allows you to Create-Read-Update-Delete questions table.</li>

<li><a href="https://server-side-scripting-assignment-2-part-3.azurewebsites.net/api/questioners">This API</a> allows you to Create-Read-Update-Delete questioners table.</li>
</ol>

<p>Bonus part: I enabled CORS. You can try CORS request with this code.</p>
<code>
fetch('https://server-side-scripting-assignment-2-part-3.azurewebsites.net/api/questions').then(response => {
  return response.json();
}).then(data => {
  console.log(data);
}).catch(err => {
console.log('Error');
});
</code>