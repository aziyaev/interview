SELECT public.user."UserName", COUNT(public.doc."DataConfidLevel") FROM public.user 
JOIN public.common 
ON public.user."UserID" = public.common."UserID" 
RIGHT JOIN public.doc 
ON public.common."DataID" = public.doc."DataID"
WHERE public.doc."DataConfidLevel" = 'Коммерческая тайна'
GROUP BY public.user."UserID"