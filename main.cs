struct animal_management{
	int animal_number ;
	int animal_row ;
	int animal_column ;
  int animal_type ;
  struct tm *at;} ;
void column_change ( struct animal_management *v ){
	v -> animal_column--;}
struct tm* datetime(){


           time_t ts;
        struct tm *ct;


        ts = time(NULL);
        ct = localtime(&ts);
int tsec1,tsec2,tsec3;
     tsec1 =  sec3;
      tsec1 += min3*60;
      tsec1 += (hour3*60)*60;
 tsec2 =  sec2;
      tsec2 += min2*60;
      tsec2 += (hour2*60)*60;

   tsec3 = tsec1 - tsec2 ;
   int secnd , minute ,hours;
   int secc , temp1,temp2,temp3,temp4 ;
      secnd = tsec3 % 60 ;
       temp1 = tsec3 - secnd ;
       temp2 = temp1/60 ;
       minute = temp2 % 60 ;
        temp4 = temp2 - minute ;
         hours = temp4 /60 ;
void animal_delete ( struct animal_management *v ){
  int c ;

	park_information[v -> animal_row][v -> animal_column] = 0 ;

	if ( v -> animal_type == cage )
    animal_counting-- ;
  else
   typeCount-- ;

	staff_counting-- ;
	backward_upward();}
oid getting_free_column_row ( int animal_type, int *arr ){
  int r, c, fromrow = 0, torow = 2 ;

  if ( animal_type ==type )
  {
    fromrow += 2 ;
    torow += 2 ;
  }

	for ( r = fromrow ; r < torow ; r++ )
	{
		for ( c = 0 ; c < 10 ; c++ )
		{
			if ( park_information[r][c] == 0 )
			{
				arr[0] = r ;
				arr[1] = c ;
        return ;
			}
		}
	}

	if ( r == 2 || r == 4 )
	{
   	arr[0] = -1 ;
    arr[1] = -1 ;
  }}
if ( animal_type ==type )
	{
    fromrow += 2 ;
    torow += 2 ;
	}

	for ( r = fromrow ; r < torow ; r++ )
	{
		for ( c = 0 ; c < 10 ; c++ )
		{
			if ( park_information[r][c] == animal_number )
			{
				arr[0] = r ;
				arr[1] = c ;
        return ;
			}
		}
	}

	if ( r == 2 || r == 4 )
	{
		arr[0] = -1 ;
		arr[1] = -1 ;
	}}
void display_main_menu( ){
  int r, c ;

  printf ( "cages ->\n" ) ;

  for ( r = 0 ; r < 4 ; r++ )
  {
    if ( r == 2 )
		  printf ( "tricycle ->\n" ) ;

    for ( c = 0 ; c < 10 ; c++ )
      printf ( "%d\t", park_information[r][c] ) ;
    printf ( "\n" ) ;
	}}
system ( "cls" ) ;

		printf ( "\ncage park\n" ) ;
		printf ( "1. Arrival of a staff\n" ) ;
		printf ( "2. Total no. of staffs park\n" ) ;
		printf ( "3. Total no. of cages park\n" ) ;
		printf ( "4. Total no. oftype park\n" ) ;
		printf ( "5. Display order in which staffs are park\n" ) ;
		printf ( "6. Departure of staff\n" ) ;
		printf ( "7. Chek History\n" ) ;
		printf ( "8. Exit\n" ) ;

		scanf ( "%d", &choice ) ;

while ( animal_type != cage && animal_type !=type )
          {
					  printf ( "Enter staff type (1 for cage / 2 fortype ): \n" ) ;
            scanf ( "%d", &animal_type ) ;
	          if ( animal_type != cage && animal_type !=type )
						  printf ( "\nInvalid staff type.\n" ) ;
          }
 if ( animal_type == cage || animal_type ==type )
				  {
					  getting_free_column_row ( animal_type, tarr ) ;

					  if ( tarr[0] != -1 && tarr[1] != -1 )
					  {
						  animal_row = tarr[0] ;
						  animal_column = tarr[1] ;

              if ( animal_type == cage )
                cage[animal_row][animal_column] =  add ( animal_type, number, animal_row, animal_column ) ;
              else
							 type[animal_row - 2][animal_column] = add ( animal_type, number, animal_row, animal_column ) ; ;
            }
