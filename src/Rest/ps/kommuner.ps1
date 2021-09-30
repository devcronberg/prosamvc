$data = Invoke-RestMethod -Uri "https://dawa.aws.dk/kommuner/"
Foreach ($d in $data)
{
    $d.Navn
}