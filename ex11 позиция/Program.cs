int []array={1,12,31,27,15,16,27,18};
int n=array.Length;
int find=27;
int index=0;
while(index<n)
{
if(array[index]==find)
{
Console.WriteLine(index);
break;
}
index++;
}