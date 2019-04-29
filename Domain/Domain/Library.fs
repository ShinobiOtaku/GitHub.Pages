(*** hide ***)
namespace Domain

(**
Domain Files
===============
Here is some documentation about my domain
*)

(*** hide ***)
module Domain =
(**
Validation
----------
This is my validation type
*)
    type Validation<'Success,'Failure> =
        Result<'Success,'Failure list>

(**It represents a Result type that can be use in an applicative way*)

(**
Other domain files
------------------
My other domain files would be defined below
*)
    type EmailAddress = EmailAddress of string

